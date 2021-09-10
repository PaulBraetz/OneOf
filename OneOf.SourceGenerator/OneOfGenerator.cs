﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace OneOf.SourceGenerator
{
    [Generator]
    public class OneOfGenerator : ISourceGenerator
    {
        private const string AttributeName = "GenerateOneOfAttribute";
        private const string AttributeNamespace = "OneOf";

        private readonly string _attributeText = $@"using System;

namespace {AttributeNamespace}
{{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class {AttributeName} : Attribute
    {{
    }}
}}
        ";

        public void Execute(GeneratorExecutionContext context)
        {
            context.AddSource(AttributeName, SourceText.From(_attributeText, Encoding.UTF8));

            if (context.SyntaxReceiver is not OneOfSyntaxReceiver receiver)
            {
                return;
            }

            if ((context.Compilation as CSharpCompilation)?.SyntaxTrees[0].Options is not CSharpParseOptions options)
            {
                return;
            }

            Compilation compilation =
                context.Compilation.AddSyntaxTrees(
                    CSharpSyntaxTree.ParseText(SourceText.From(_attributeText, Encoding.UTF8), options));

            INamedTypeSymbol? attributeSymbol =
                compilation.GetTypeByMetadataName($"{AttributeNamespace}.{AttributeName}");

            if (attributeSymbol is null)
            {
                return;
            }

            List<(INamedTypeSymbol, Location?)> namedTypeSymbols = new();
            foreach (ClassDeclarationSyntax classDeclaration in receiver.CandidateClasses)
            {
                SemanticModel model = compilation.GetSemanticModel(classDeclaration.SyntaxTree);
                INamedTypeSymbol? namedTypeSymbol = model.GetDeclaredSymbol(classDeclaration);

                AttributeData? attributeData = namedTypeSymbol?.GetAttributes().FirstOrDefault(ad =>
                    ad.AttributeClass?.Equals(attributeSymbol, SymbolEqualityComparer.Default) != false);

                if (attributeData is not null)
                {
                    namedTypeSymbols.Add((namedTypeSymbol!,
                        attributeData.ApplicationSyntaxReference?.GetSyntax().GetLocation()));
                }
            }

            foreach ((INamedTypeSymbol namedSymbol, Location? attributeLocation) in namedTypeSymbols)
            {
                string? classSource = ProcessClass(namedSymbol, context, attributeLocation);

                if (classSource is null)
                {
                    continue;
                }

                context.AddSource($"{namedSymbol.ContainingNamespace}_{namedSymbol.Name}.generated.cs",
                    SourceText.From(classSource, Encoding.UTF8));
            }
        }

        private static string? ProcessClass(INamedTypeSymbol classSymbol, GeneratorExecutionContext context,
            Location? attributeLocation)
        {
            attributeLocation ??= Location.None;

            if (!classSymbol.ContainingSymbol.Equals(classSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
            {
                context.ReportDiagnostic(Diagnostic.Create(GeneratorDiagnosticDescriptors.TopLevelError,
                    attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            if (classSymbol.BaseType is null || classSymbol.BaseType.Name != "OneOfBase" ||
                classSymbol.BaseType.ContainingNamespace.ToString() != "OneOf")
            {
                context.ReportDiagnostic(Diagnostic.Create(GeneratorDiagnosticDescriptors.WrongBaseType,
                    attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            if (classSymbol.DeclaredAccessibility != Accessibility.Public)
            {
                context.ReportDiagnostic(Diagnostic.Create(GeneratorDiagnosticDescriptors.ClassIsNotPublic,
                    attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            ImmutableArray<ITypeSymbol> typeArguments = classSymbol.BaseType.TypeArguments;

            if (typeArguments.Any(x => x.Name == nameof(Object)))
            {
                context.ReportDiagnostic(Diagnostic.Create(GeneratorDiagnosticDescriptors.ObjectIsOneOfType,
                    attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            return GenerateClassSource(classSymbol, classSymbol.BaseType.TypeParameters, typeArguments);
        }

        private static string GenerateClassSource(INamedTypeSymbol classSymbol,
            ImmutableArray<ITypeParameterSymbol> typeParameters, ImmutableArray<ITypeSymbol> typeArguments)
        {
            IEnumerable<(ITypeParameterSymbol param, ITypeSymbol arg)> paramArgPairs =
                typeParameters.Zip(typeArguments, (param, arg) => (param, arg));

            string oneOfGenericPart = GetGenericPart(typeArguments);

            string classNameWithGenericTypes = $"{classSymbol.Name}{GetOpenGenericPart(classSymbol)}";

            StringBuilder source = new($@"using System;

namespace {classSymbol.ContainingNamespace.ToDisplayString()}
{{
    public partial class {classNameWithGenericTypes}");

            source.Append($@"
    {{
        public {classSymbol.Name}(OneOf.OneOf<{oneOfGenericPart}> _) : base(_) {{ }}
");

            foreach ((ITypeParameterSymbol param, ITypeSymbol arg) in paramArgPairs)
            {
                source.Append($@"
        public static implicit operator {classNameWithGenericTypes}({arg.ToDisplayString()} _) => new {classNameWithGenericTypes}(_);
        public static explicit operator {arg.ToDisplayString()}({classNameWithGenericTypes} _) => _.As{param.Name};
");
            }

            source.Append(@"    }
}");
            return source.ToString();
        }

        private static string GetGenericPart(ImmutableArray<ITypeSymbol> typeArguments) =>
            string.Join(", ", typeArguments.Select(x => x.ToDisplayString()));

        private static string? GetOpenGenericPart(INamedTypeSymbol classSymbol)
        {
            if (!classSymbol.TypeArguments.Any())
            {
                return null;
            }

            return $"<{GetGenericPart(classSymbol.TypeArguments)}>";
        }

        public void Initialize(GeneratorInitializationContext context)
            => context.RegisterForSyntaxNotifications(() => new OneOfSyntaxReceiver());

        internal class OneOfSyntaxReceiver : ISyntaxReceiver
        {
            public List<ClassDeclarationSyntax> CandidateClasses { get; } = new();

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (syntaxNode is ClassDeclarationSyntax { AttributeLists: { Count: > 0 } } classDeclarationSyntax
                    && classDeclarationSyntax.Modifiers.Any(SyntaxKind.PartialKeyword))
                {
                    CandidateClasses.Add(classDeclarationSyntax);
                }
            }
        }
    }
}
