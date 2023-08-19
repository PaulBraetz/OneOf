using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 5 types.
    /// </summary>
    /// <typeparam name="T0">The first type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T1">The second type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T2">The third type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T3">The fourth type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T4">The fifth type of value this type of union is able to represent.</typeparam>
    public class OneOfBase<T0, T1, T2, T3, T4> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly int _index;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="input">The union based on which to set the type and value represented by this union.</param>
        protected OneOfBase(OneOf<T0, T1, T2, T3, T4> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: 
                    _value0 = input.AsT0; 
                    break;
                case 1: 
                    _value1 = input.AsT1; 
                    break;
                case 2: 
                    _value2 = input.AsT2; 
                    break;
                case 3: 
                    _value3 = input.AsT3; 
                    break;
                case 4: 
                    _value4 = input.AsT4; 
                    break;
                default: 
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
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
                case 3: 
                    return typeof(T3);
                case 4: 
                    return typeof(T4);
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
                    case 3: 
                        return _value3;
                    case 4: 
                        return _value4;
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
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T3"/>.
        /// </summary>
        public bool IsT3 => _index == 3;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T4"/>.
        /// </summary>
        public bool IsT4 => _index == 4;

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
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T3"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new InvalidOperationException($"Cannot return the value represented as T3 ({typeof(T3).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T4"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new InvalidOperationException($"Cannot return the value represented as T4 ({typeof(T4).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");

        

        /// <summary>
        /// Executes a delegate based on the type of value represented by this union.
        /// </summary>
		/// <param name="f0">The delegate to execute if this union represents a value of type <typeparamref name="T0"/>.</param>
		/// <param name="f1">The delegate to execute if this union represents a value of type <typeparamref name="T1"/>.</param>
		/// <param name="f2">The delegate to execute if this union represents a value of type <typeparamref name="T2"/>.</param>
		/// <param name="f3">The delegate to execute if this union represents a value of type <typeparamref name="T3"/>.</param>
		/// <param name="f4">The delegate to execute if this union represents a value of type <typeparamref name="T4"/>.</param>
        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
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
                case 3: 
                    if(f3 == null)
                    {
                        throw new ArgumentNullException(nameof(f3), $"The union is representing a value of type {typeof(T3).FullName} but no switch delegate was provided for its index.");
                    }
                    f3.Invoke(_value3);
                    return;
                case 4: 
                    if(f4 == null)
                    {
                        throw new ArgumentNullException(nameof(f4), $"The union is representing a value of type {typeof(T4).FullName} but no switch delegate was provided for its index.");
                    }
                    f4.Invoke(_value4);
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
		/// <param name="f3">The projection to execute if this union represents a value of type <typeparamref name="T3"/>.</param>
		/// <param name="f4">The projection to execute if this union represents a value of type <typeparamref name="T4"/>.</param>
        /// <returns>The projected value.</returns>
        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4)
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
                case 3: 
                    if(f3 == null)
                    {
                        throw new ArgumentNullException(nameof(f3), $"The union is representing a value of type {typeof(T3).FullName} but no match projection was provided for its index.");
                    }
                    return f3.Invoke(_value3);
                case 4: 
                    if(f4 == null)
                    {
                        throw new ArgumentNullException(nameof(f4), $"The union is representing a value of type {typeof(T4).FullName} but no match projection was provided for its index.");
                    }
                    return f4.Invoke(_value4);
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
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4> remainder)
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
                case 3:
                    remainder = AsT3;
                    break;
                case 4:
                    remainder = AsT4;
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
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4> remainder)
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
                case 3:
                    remainder = AsT3;
                    break;
                case 4:
                    remainder = AsT4;
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
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4> remainder)
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
                case 3:
                    remainder = AsT3;
                    break;
                case 4:
                    remainder = AsT4;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT2;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T3"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T3"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T3"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T3"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4> remainder)
		{
			value = IsT3 ? AsT3 : default;
            switch(_index)
            {
                case 0:
                    remainder = AsT0;
                    break;
                case 1:
                    remainder = AsT1;
                    break;
                case 2:
                    remainder = AsT2;
                    break;
                case 3:
                    remainder = default;
                    break;
                case 4:
                    remainder = AsT4;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT3;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T4"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T4"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T4"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T4"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3> remainder)
		{
			value = IsT4 ? AsT4 : default;
            switch(_index)
            {
                case 0:
                    remainder = AsT0;
                    break;
                case 1:
                    remainder = AsT1;
                    break;
                case 2:
                    remainder = AsT2;
                    break;
                case 3:
                    remainder = AsT3;
                    break;
                case 4:
                    remainder = default;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT4;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4> other)
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
                case 3: 
                    return Equals(_value3, other._value3);
                case 4: 
                    return Equals(_value4, other._value4);
                default:
                    return false;
            };
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            obj != null && (ReferenceEquals(this, obj) || obj is OneOfBase<T0, T1, T2, T3, T4> o && Equals(o));

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
                case 3:
                    return _value3?.ToString();
                case 4:
                    return _value4?.ToString();
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
                    case 3:
                        hashCode = _value3?.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4?.GetHashCode();
                        break;
                    default:
                        hashCode = null;
                        break;
                };

                return ((hashCode ?? 0) * 397) ^ _index;
            }
        }
    }
}
