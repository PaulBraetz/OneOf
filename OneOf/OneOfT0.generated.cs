using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 1 type.
    /// </summary>
    /// <typeparam name="T0">The first type of value this type of union is able to represent.</typeparam>
    public readonly struct OneOf<T0> : IOneOf, IEquatable<OneOf<T0>>
    {
        readonly T0 _value0;
        readonly int _index;

        OneOf(int index, T0 value0 = default)
        {
            _index = index;
            _value0 = value0;
        }
        
        /// <summary>
        /// Gets the type of value represented by this union.
        /// </summary>
        public Type GetRepresentedType()
        {
            switch(_index)
            {
                case 0: 
                    return typeof(T0);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
        }

        /// <summary>
        /// Gets the value represented by this union.
        /// </summary>
        public object Value
        {
            get
            {
                switch(_index)
                {
                    case 0: 
                        return _value0;
                    default:
                        throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
                };
            }
        }

        /// <summary>
        /// Gets the index indicating the type of value represented by this union.
        /// </summary>
        public int Index => _index;

        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T0"/>.
        /// </summary>
        public bool IsT0 => _index == 0;

        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T0"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return the value represented as T0 ({typeof(T0).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");

        public static implicit operator OneOf<T0>(T0 value) => new OneOf<T0>(0, value0: value);

        /// <summary>
        /// Executes a delegate based on the type of value represented by this union.
        /// </summary>
		/// <param name="f0">The delegate to execute if this union represents a value of type <typeparamref name="T0"/>.</param>
        public void Switch(Action<T0> f0)
        {
            switch(_index)
            {
                case 0: 
                    if(f0 == null)
                    {
                        throw new ArgumentNullException(nameof(f0), $"The union is representing a value of type {typeof(T0).FullName} but no switch delegate was provided for its index.");
                    }
                    f0.Invoke(_value0);
                    return;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <summary>
        /// Projects the value represented by this union onto the type <typeparamref name="TResult"/>.
        /// </summary>
		/// <param name="f0">The projection to execute if this union represents a value of type <typeparamref name="T0"/>.</param>
        /// <returns>The projected value.</returns>
        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            switch(_index)
            {
                case 0: 
                    if(f0 == null)
                    {
                        throw new ArgumentNullException(nameof(f0), $"The union is representing a value of type {typeof(T0).FullName} but no match projection was provided for its index.");
                    }
                    return f0.Invoke(_value0);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0> FromT0(T0 value) => value;

        
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its first type (<typeparamref name="T0"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T0"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the first type (<typeparamref name="T0"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<TResult> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }

            switch(_index)
            {
                case 0:
                    return mapFunc.Invoke(AsT0);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <inheritdoc/>
        public bool Equals(OneOf<T0> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0: 
                    return Equals(_value0, other._value0);
                default:
                    return false;
            };
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            obj is OneOf<T0> o && Equals(o);

        /// <inheritdoc/>
        public override string ToString()
        {
            switch(_index)
            {
                case 0:
                    return FormatValue(_value0);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                int? hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0?.GetHashCode();
                        break;
                    default:
                        hashCode = null;
                        break;
                };

                return ((hashCode ?? 0) * 397) ^ _index;
            }
        }
        public static bool operator ==(OneOf<T0> a,OneOf<T0> b) =>
            a.Equals(b);
        public static bool operator !=(OneOf<T0> a,OneOf<T0> b) =>
            !(a == b);
    }
}
