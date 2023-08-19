using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 10 types.
    /// </summary>
    /// <typeparam name="T0">The first type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T1">The second type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T2">The third type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T3">The fourth type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T4">The fifth type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T5">The sixth type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T6">The seventh type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T7">The eigth type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T8">The ninth type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T9">The tenth type of value this type of union is able to represent.</typeparam>
    public readonly struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IOneOf, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default, T8 value8 = default, T9 value9 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
            _value8 = value8;
            _value9 = value9;
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
                case 5: 
                    return typeof(T5);
                case 6: 
                    return typeof(T6);
                case 7: 
                    return typeof(T7);
                case 8: 
                    return typeof(T8);
                case 9: 
                    return typeof(T9);
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
                    case 5: 
                        return _value5;
                    case 6: 
                        return _value6;
                    case 7: 
                        return _value7;
                    case 8: 
                        return _value8;
                    case 9: 
                        return _value9;
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
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T5"/>.
        /// </summary>
        public bool IsT5 => _index == 5;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T6"/>.
        /// </summary>
        public bool IsT6 => _index == 6;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T7"/>.
        /// </summary>
        public bool IsT7 => _index == 7;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T8"/>.
        /// </summary>
        public bool IsT8 => _index == 8;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T9"/>.
        /// </summary>
        public bool IsT9 => _index == 9;

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
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T5"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new InvalidOperationException($"Cannot return the value represented as T5 ({typeof(T5).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T6"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new InvalidOperationException($"Cannot return the value represented as T6 ({typeof(T6).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T7"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T7 AsT7 =>
            _index == 7 ?
                _value7 :
                throw new InvalidOperationException($"Cannot return the value represented as T7 ({typeof(T7).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T8"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T8 AsT8 =>
            _index == 8 ?
                _value8 :
                throw new InvalidOperationException($"Cannot return the value represented as T8 ({typeof(T8).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T9"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T9 AsT9 =>
            _index == 9 ?
                _value9 :
                throw new InvalidOperationException($"Cannot return the value represented as T9 ({typeof(T9).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(0, value0: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(1, value1: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(2, value2: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(3, value3: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(4, value4: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(5, value5: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(6, value6: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(7, value7: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(8, value8: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(9, value9: value);

        /// <summary>
        /// Executes a delegate based on the type of value represented by this union.
        /// </summary>
		/// <param name="f0">The delegate to execute if this union represents a value of type <typeparamref name="T0"/>.</param>
		/// <param name="f1">The delegate to execute if this union represents a value of type <typeparamref name="T1"/>.</param>
		/// <param name="f2">The delegate to execute if this union represents a value of type <typeparamref name="T2"/>.</param>
		/// <param name="f3">The delegate to execute if this union represents a value of type <typeparamref name="T3"/>.</param>
		/// <param name="f4">The delegate to execute if this union represents a value of type <typeparamref name="T4"/>.</param>
		/// <param name="f5">The delegate to execute if this union represents a value of type <typeparamref name="T5"/>.</param>
		/// <param name="f6">The delegate to execute if this union represents a value of type <typeparamref name="T6"/>.</param>
		/// <param name="f7">The delegate to execute if this union represents a value of type <typeparamref name="T7"/>.</param>
		/// <param name="f8">The delegate to execute if this union represents a value of type <typeparamref name="T8"/>.</param>
		/// <param name="f9">The delegate to execute if this union represents a value of type <typeparamref name="T9"/>.</param>
        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9)
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
                case 5: 
                    if(f5 == null)
                    {
                        throw new ArgumentNullException(nameof(f5), $"The union is representing a value of type {typeof(T5).FullName} but no switch delegate was provided for its index.");
                    }
                    f5.Invoke(_value5);
                    return;
                case 6: 
                    if(f6 == null)
                    {
                        throw new ArgumentNullException(nameof(f6), $"The union is representing a value of type {typeof(T6).FullName} but no switch delegate was provided for its index.");
                    }
                    f6.Invoke(_value6);
                    return;
                case 7: 
                    if(f7 == null)
                    {
                        throw new ArgumentNullException(nameof(f7), $"The union is representing a value of type {typeof(T7).FullName} but no switch delegate was provided for its index.");
                    }
                    f7.Invoke(_value7);
                    return;
                case 8: 
                    if(f8 == null)
                    {
                        throw new ArgumentNullException(nameof(f8), $"The union is representing a value of type {typeof(T8).FullName} but no switch delegate was provided for its index.");
                    }
                    f8.Invoke(_value8);
                    return;
                case 9: 
                    if(f9 == null)
                    {
                        throw new ArgumentNullException(nameof(f9), $"The union is representing a value of type {typeof(T9).FullName} but no switch delegate was provided for its index.");
                    }
                    f9.Invoke(_value9);
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
		/// <param name="f5">The projection to execute if this union represents a value of type <typeparamref name="T5"/>.</param>
		/// <param name="f6">The projection to execute if this union represents a value of type <typeparamref name="T6"/>.</param>
		/// <param name="f7">The projection to execute if this union represents a value of type <typeparamref name="T7"/>.</param>
		/// <param name="f8">The projection to execute if this union represents a value of type <typeparamref name="T8"/>.</param>
		/// <param name="f9">The projection to execute if this union represents a value of type <typeparamref name="T9"/>.</param>
        /// <returns>The projected value.</returns>
        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9)
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
                case 5: 
                    if(f5 == null)
                    {
                        throw new ArgumentNullException(nameof(f5), $"The union is representing a value of type {typeof(T5).FullName} but no match projection was provided for its index.");
                    }
                    return f5.Invoke(_value5);
                case 6: 
                    if(f6 == null)
                    {
                        throw new ArgumentNullException(nameof(f6), $"The union is representing a value of type {typeof(T6).FullName} but no match projection was provided for its index.");
                    }
                    return f6.Invoke(_value6);
                case 7: 
                    if(f7 == null)
                    {
                        throw new ArgumentNullException(nameof(f7), $"The union is representing a value of type {typeof(T7).FullName} but no match projection was provided for its index.");
                    }
                    return f7.Invoke(_value7);
                case 8: 
                    if(f8 == null)
                    {
                        throw new ArgumentNullException(nameof(f8), $"The union is representing a value of type {typeof(T8).FullName} but no match projection was provided for its index.");
                    }
                    return f8.Invoke(_value8);
                case 9: 
                    if(f9 == null)
                    {
                        throw new ArgumentNullException(nameof(f9), $"The union is representing a value of type {typeof(T9).FullName} but no match projection was provided for its index.");
                    }
                    return f9.Invoke(_value9);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT0(T0 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT1(T1 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT2(T2 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT3(T3 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT4(T4 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT5(T5 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT6(T6 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT7(T7 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT8(T8 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT9(T9 value) => value;

        
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
        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> MapT0<TResult>(Func<T0, TResult> mapFunc)
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
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
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
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8, T9> MapT1<TResult>(Func<T1, TResult> mapFunc)
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
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
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
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8, T9> MapT2<TResult>(Func<T2, TResult> mapFunc)
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
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its fourth type (<typeparamref name="T3"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T3"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the fourth type (<typeparamref name="T3"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8, T9> MapT3<TResult>(Func<T3, TResult> mapFunc)
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
                    return AsT2;
                case 3:
                    return mapFunc.Invoke(AsT3);
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its fifth type (<typeparamref name="T4"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T4"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the fifth type (<typeparamref name="T4"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8, T9> MapT4<TResult>(Func<T4, TResult> mapFunc)
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
                    return AsT2;
                case 3:
                    return AsT3;
                case 4:
                    return mapFunc.Invoke(AsT4);
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its sixth type (<typeparamref name="T5"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T5"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the sixth type (<typeparamref name="T5"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8, T9> MapT5<TResult>(Func<T5, TResult> mapFunc)
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
                    return AsT2;
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return mapFunc.Invoke(AsT5);
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its seventh type (<typeparamref name="T6"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T6"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the seventh type (<typeparamref name="T6"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8, T9> MapT6<TResult>(Func<T6, TResult> mapFunc)
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
                    return AsT2;
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return mapFunc.Invoke(AsT6);
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its eigth type (<typeparamref name="T7"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T7"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the eigth type (<typeparamref name="T7"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8, T9> MapT7<TResult>(Func<T7, TResult> mapFunc)
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
                    return AsT2;
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return mapFunc.Invoke(AsT7);
                case 8:
                    return AsT8;
                case 9:
                    return AsT9;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its ninth type (<typeparamref name="T8"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T8"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the ninth type (<typeparamref name="T8"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult, T9> MapT8<TResult>(Func<T8, TResult> mapFunc)
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
                    return AsT2;
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return mapFunc.Invoke(AsT8);
                case 9:
                    return AsT9;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its tenth type (<typeparamref name="T9"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T9"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the tenth type (<typeparamref name="T9"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> MapT9<TResult>(Func<T9, TResult> mapFunc)
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
                    return AsT2;
                case 3:
                    return AsT3;
                case 4:
                    return AsT4;
                case 5:
                    return AsT5;
                case 6:
                    return AsT6;
                case 7:
                    return AsT7;
                case 8:
                    return AsT8;
                case 9:
                    return mapFunc.Invoke(AsT9);
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
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> remainder)
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
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
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
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9> remainder)
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
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
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
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9> remainder)
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
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
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
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9> remainder)
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
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
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
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9> remainder)
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
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT4;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T5"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T5"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T5"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T5"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9> remainder)
		{
			value = IsT5 ? AsT5 : default;
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
                    remainder = AsT4;
                    break;
                case 5:
                    remainder = default;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT5;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T6"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T6"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T6"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T6"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9> remainder)
		{
			value = IsT6 ? AsT6 : default;
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
                    remainder = AsT4;
                    break;
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = default;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT6;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T7"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T7"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T7"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T7"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9> remainder)
		{
			value = IsT7 ? AsT7 : default;
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
                    remainder = AsT4;
                    break;
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = default;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = AsT9;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT7;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T8"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T8"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T8"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T8"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9> remainder)
		{
			value = IsT8 ? AsT8 : default;
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
                    remainder = AsT4;
                    break;
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = default;
                    break;
                case 9:
                    remainder = AsT9;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT8;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T9"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T9"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T9"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T9"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> remainder)
		{
			value = IsT9 ? AsT9 : default;
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
                    remainder = AsT4;
                    break;
                case 5:
                    remainder = AsT5;
                    break;
                case 6:
                    remainder = AsT6;
                    break;
                case 7:
                    remainder = AsT7;
                    break;
                case 8:
                    remainder = AsT8;
                    break;
                case 9:
                    remainder = default;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT9;
		}

        /// <inheritdoc/>
        public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
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
                case 5: 
                    return Equals(_value5, other._value5);
                case 6: 
                    return Equals(_value6, other._value6);
                case 7: 
                    return Equals(_value7, other._value7);
                case 8: 
                    return Equals(_value8, other._value8);
                case 9: 
                    return Equals(_value9, other._value9);
                default:
                    return false;
            };
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> o && Equals(o);

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
                case 5:
                    return _value5?.ToString();
                case 6:
                    return _value6?.ToString();
                case 7:
                    return _value7?.ToString();
                case 8:
                    return _value8?.ToString();
                case 9:
                    return _value9?.ToString();
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
                    case 5:
                        hashCode = _value5?.GetHashCode();
                        break;
                    case 6:
                        hashCode = _value6?.GetHashCode();
                        break;
                    case 7:
                        hashCode = _value7?.GetHashCode();
                        break;
                    case 8:
                        hashCode = _value8?.GetHashCode();
                        break;
                    case 9:
                        hashCode = _value9?.GetHashCode();
                        break;
                    default:
                        hashCode = null;
                        break;
                };

                return ((hashCode ?? 0) * 397) ^ _index;
            }
        }
        public static bool operator ==(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> a,OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> b) =>
            a.Equals(b);
        public static bool operator !=(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> a,OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> b) =>
            !(a == b);
    }
}
