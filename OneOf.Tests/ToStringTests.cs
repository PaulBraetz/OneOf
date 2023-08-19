﻿using System;
using System.Globalization;
using System.Threading;

using NUnit.Framework;

namespace OneOf.Tests
{
    public class ToStringTests
    {
        static string RunInCulture(CultureInfo culture, Func<string> action)
        {
            var originalCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            try
            {
                return action();
            } finally
            {
                Thread.CurrentThread.CurrentCulture = originalCulture;
            }
        }

        [TestCase("en-NZ", ExpectedResult = "2/01/2019 1:02:03 am")]
        [TestCase("en-US", ExpectedResult = "1/2/2019 1:02:03 AM")]
        public string LeftSideFormatsWithCurrentCulture(string cultureName)
        {
            return RunInCulture(new CultureInfo(cultureName, false), () =>
            {
                OneOf<DateTime, string> a = new DateTime(2019, 1, 2, 1, 2, 3);
                return a.ToString();
            });
        }

        [TestCase("en-NZ", ExpectedResult = "2/01/2019 1:02:03 am")]
        [TestCase("en-US", ExpectedResult = "1/2/2019 1:02:03 AM")]
        public string RightSideFormatsWithCurrentCulture(string cultureName)
        {
            return RunInCulture(new CultureInfo(cultureName, false), () =>
            {
                OneOf<string, DateTime> a = new DateTime(2019, 1, 2, 1, 2, 3);
                return a.ToString();
            });
        }

        [Test]
        public void TheValueIsReturnedAsIs()
        {
            OneOf<string, int, DateTime, decimal> a = 42;
            Assert.AreEqual(42.ToString(), a.ToString());
        }

        public class RecursiveOneOf : OneOfBase<RecursiveOneOf.InnerOne, RecursiveOneOf.InnerTwo>
        {
            RecursiveOneOf(OneOf<InnerOne, InnerTwo> _) : base(_) { }
            public class InnerOne { }
            public class InnerTwo { }
        }

        [Test]
        public void CallingToStringOnARecursiveTypeWorks()
        {
            var innerTypeOfRecursiveOneOf = new RecursiveOneOf.InnerOne();

            Assert.AreEqual("OneOf.Tests.ToStringTests+RecursiveOneOf+InnerOne", innerTypeOfRecursiveOneOf.ToString());
        }

        [Test]
        public void CallingToStringOnANestedNonRecursiveTypeWorks()
        {
            OneOf<OneOf<string, bool>, OneOf<bool, string>> nestedType = (OneOf<string, bool>)true;

            Assert.AreEqual(true.ToString(), nestedType.ToString());
        }
    }
}
