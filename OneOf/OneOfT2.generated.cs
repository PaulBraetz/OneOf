using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 3 types.
    /// </summary>
    /// <typeparam name="T0">The first type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T1">The second type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T2">The third type of value this type of union is able to represent.</typeparam>
    public readonly struct OneOf<T0, T1, T2> : IOneOf, IEquatable<OneOf<T0, T1, T2>>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
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
                case 1: 
                    return typeof(T1);
                case 2: 
                    return typeof(T2);
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
                    case 1: 
                        return _value1;
                    case 2: 
                        return _value2;
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
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T1"/>.
        /// </summary>
        public bool IsT1 => _index == 1;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T2"/>.
        /// </summary>
        public bool IsT2 => _index == 2;

        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T0"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return the value represented as T0 ({typeof(T0).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T1"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException($"Cannot return the value represented as T1 ({typeof(T1).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T2"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new InvalidOperationException($"Cannot return the value represented as T2 ({typeof(T2).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");

        public static implicit operator OneOf<T0, T1, T2>(T0 value) => new OneOf<T0, T1, T2>(0, value0: value);
        public static implicit operator OneOf<T0, T1, T2>(T1 value) => new OneOf<T0, T1, T2>(1, value1: value);
        public static implicit operator OneOf<T0, T1, T2>(T2 value) => new OneOf<T0, T1, T2>(2, value2: value);

        /// <summary>
        /// Executes a delegate based on the type of value represented by this union.
        /// </summary>
		/// <param name="f0">The delegate to execute if this union represents a value of type <typeparamref name="T0"/>.</param>
		/// <param name="f1">The delegate to execute if this union represents a value of type <typeparamref name="T1"/>.</param>
		/// <param name="f2">The delegate to execute if this union represents a value of type <typeparamref name="T2"/>.</param>
        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2)
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
                case 1: 
                    if(f1 == null)
                    {
                        throw new ArgumentNullException(nameof(f1), $"The union is representing a value of type {typeof(T1).FullName} but no switch delegate was provided for its index.");
                    }
                    f1.Invoke(_value1);
                    return;
                case 2: 
                    if(f2 == null)
                    {
                        throw new ArgumentNullException(nameof(f2), $"The union is representing a value of type {typeof(T2).FullName} but no switch delegate was provided for its index.");
                    }
                    f2.Invoke(_value2);
                    return;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <summary>
        /// Projects the value represented by this union onto the type <typeparamref name="TResult"/>.
        /// </summary>
		/// <param name="f0">The projection to execute if this union represents a value of type <typeparamref name="T0"/>.</param>
		/// <param name="f1">The projection to execute if this union represents a value of type <typeparamref name="T1"/>.</param>
		/// <param name="f2">The projection to execute if this union represents a value of type <typeparamref name="T2"/>.</param>
        /// <returns>The projected value.</returns>
        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2)
        {
            switch(_index)
            {
                case 0: 
                    if(f0 == null)
                    {
                        throw new ArgumentNullException(nameof(f0), $"The union is representing a value of type {typeof(T0).FullName} but no match projection was provided for its index.");
                    }
                    return f0.Invoke(_value0);
                case 1: 
                    if(f1 == null)
                    {
                        throw new ArgumentNullException(nameof(f1), $"The union is representing a value of type {typeof(T1).FullName} but no match projection was provided for its index.");
                    }
                    return f1.Invoke(_value1);
                case 2: 
                    if(f2 == null)
                    {
                        throw new ArgumentNullException(nameof(f2), $"The union is representing a value of type {typeof(T2).FullName} but no match projection was provided for its index.");
                    }
                    return f2.Invoke(_value2);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2> FromT0(T0 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2> FromT1(T1 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2> FromT2(T2 value) => value;

        
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
        public OneOf<TResult, T1, T2> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }

            switch(_index)
            {
                case 0:
                    return mapFunc.Invoke(AsT0);
                case 1:
                    return AsT1;
                case 2:
                    return AsT2;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its second type (<typeparamref name="T1"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T1"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the second type (<typeparamref name="T1"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, TResult, T2> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }

            switch(_index)
            {
                case 0:
                    return AsT0;
                case 1:
                    return mapFunc.Invoke(AsT1);
                case 2:
                    return AsT2;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its third type (<typeparamref name="T2"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T2"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the third type (<typeparamref name="T2"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, TResult> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }

            switch(_index)
            {
                case 0:
                    return AsT0;
                case 1:
                    return AsT1;
                case 2:
                    return mapFunc.Invoke(AsT2);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T0"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T0"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T0"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T0"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT0(out T0 value, out OneOf<T1, T2> remainder)
		{
			value = IsT0 ? AsT0 : default;
            switch(_index)
            {
                case 0:
                    remainder = default;
                    break;
                case 1:
                    remainder = AsT1;
                    break;
                case 2:
                    remainder = AsT2;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT0;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T1"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T1"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T1"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T1"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT1(out T1 value, out OneOf<T0, T2> remainder)
		{
			value = IsT1 ? AsT1 : default;
            switch(_index)
            {
                case 0:
                    remainder = AsT0;
                    break;
                case 1:
                    remainder = default;
                    break;
                case 2:
                    remainder = AsT2;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT1;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T2"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T2"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T2"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T2"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT2(out T2 value, out OneOf<T0, T1> remainder)
		{
			value = IsT2 ? AsT2 : default;
            switch(_index)
            {
                case 0:
                    remainder = AsT0;
                    break;
                case 1:
                    remainder = AsT1;
                    break;
                case 2:
                    remainder = default;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT2;
		}

        /// <inheritdoc/>
        public bool Equals(OneOf<T0, T1, T2> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0: 
                    return Equals(_value0, other._value0);
                case 1: 
                    return Equals(_value1, other._value1);
                case 2: 
                    return Equals(_value2, other._value2);
                default:
                    return false;
            };
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            obj is OneOf<T0, T1, T2> o && Equals(o);

        /// <inheritdoc/>
        public override string ToString()
        {
            switch(_index)
            {
                case 0:
                    return _value0?.ToString();
                case 1:
                    return _value1?.ToString();
                case 2:
                    return _value2?.ToString();
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
                    case 1:
                        hashCode = _value1?.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2?.GetHashCode();
                        break;
                    default:
                        hashCode = null;
                        break;
                };

                return ((hashCode ?? 0) * 397) ^ _index;
            }
        }
        public static bool operator ==(OneOf<T0, T1, T2> a,OneOf<T0, T1, T2> b) =>
            a.Equals(b);
        public static bool operator !=(OneOf<T0, T1, T2> a,OneOf<T0, T1, T2> b) =>
            !(a == b);
    }
}
