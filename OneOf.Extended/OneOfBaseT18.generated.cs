using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 19 types.
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
    /// <typeparam name="T10">The eleventh type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T11">The twelfth type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T12">The 12th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T13">The 13th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T14">The 14th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T15">The 15th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T16">The 16th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T17">The 17th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T18">The 18th type of value this type of union is able to represent.</typeparam>
    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : IOneOf
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
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly int _index;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="input">The union based on which to set the type and value represented by this union.</param>
        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> input)
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
                case 5: 
                    _value5 = input.AsT5; 
                    break;
                case 6: 
                    _value6 = input.AsT6; 
                    break;
                case 7: 
                    _value7 = input.AsT7; 
                    break;
                case 8: 
                    _value8 = input.AsT8; 
                    break;
                case 9: 
                    _value9 = input.AsT9; 
                    break;
                case 10: 
                    _value10 = input.AsT10; 
                    break;
                case 11: 
                    _value11 = input.AsT11; 
                    break;
                case 12: 
                    _value12 = input.AsT12; 
                    break;
                case 13: 
                    _value13 = input.AsT13; 
                    break;
                case 14: 
                    _value14 = input.AsT14; 
                    break;
                case 15: 
                    _value15 = input.AsT15; 
                    break;
                case 16: 
                    _value16 = input.AsT16; 
                    break;
                case 17: 
                    _value17 = input.AsT17; 
                    break;
                case 18: 
                    _value18 = input.AsT18; 
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
                case 10: 
                    return typeof(T10);
                case 11: 
                    return typeof(T11);
                case 12: 
                    return typeof(T12);
                case 13: 
                    return typeof(T13);
                case 14: 
                    return typeof(T14);
                case 15: 
                    return typeof(T15);
                case 16: 
                    return typeof(T16);
                case 17: 
                    return typeof(T17);
                case 18: 
                    return typeof(T18);
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
                    case 10: 
                        return _value10;
                    case 11: 
                        return _value11;
                    case 12: 
                        return _value12;
                    case 13: 
                        return _value13;
                    case 14: 
                        return _value14;
                    case 15: 
                        return _value15;
                    case 16: 
                        return _value16;
                    case 17: 
                        return _value17;
                    case 18: 
                        return _value18;
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
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T10"/>.
        /// </summary>
        public bool IsT10 => _index == 10;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T11"/>.
        /// </summary>
        public bool IsT11 => _index == 11;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T12"/>.
        /// </summary>
        public bool IsT12 => _index == 12;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T13"/>.
        /// </summary>
        public bool IsT13 => _index == 13;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T14"/>.
        /// </summary>
        public bool IsT14 => _index == 14;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T15"/>.
        /// </summary>
        public bool IsT15 => _index == 15;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T16"/>.
        /// </summary>
        public bool IsT16 => _index == 16;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T17"/>.
        /// </summary>
        public bool IsT17 => _index == 17;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T18"/>.
        /// </summary>
        public bool IsT18 => _index == 18;

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
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T10"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T10 AsT10 =>
            _index == 10 ?
                _value10 :
                throw new InvalidOperationException($"Cannot return the value represented as T10 ({typeof(T10).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T11"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T11 AsT11 =>
            _index == 11 ?
                _value11 :
                throw new InvalidOperationException($"Cannot return the value represented as T11 ({typeof(T11).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T12"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T12 AsT12 =>
            _index == 12 ?
                _value12 :
                throw new InvalidOperationException($"Cannot return the value represented as T12 ({typeof(T12).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T13"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T13 AsT13 =>
            _index == 13 ?
                _value13 :
                throw new InvalidOperationException($"Cannot return the value represented as T13 ({typeof(T13).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T14"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T14 AsT14 =>
            _index == 14 ?
                _value14 :
                throw new InvalidOperationException($"Cannot return the value represented as T14 ({typeof(T14).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T15"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T15 AsT15 =>
            _index == 15 ?
                _value15 :
                throw new InvalidOperationException($"Cannot return the value represented as T15 ({typeof(T15).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T16"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T16 AsT16 =>
            _index == 16 ?
                _value16 :
                throw new InvalidOperationException($"Cannot return the value represented as T16 ({typeof(T16).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T17"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T17 AsT17 =>
            _index == 17 ?
                _value17 :
                throw new InvalidOperationException($"Cannot return the value represented as T17 ({typeof(T17).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T18"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T18 AsT18 =>
            _index == 18 ?
                _value18 :
                throw new InvalidOperationException($"Cannot return the value represented as T18 ({typeof(T18).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");

        

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
		/// <param name="f10">The delegate to execute if this union represents a value of type <typeparamref name="T10"/>.</param>
		/// <param name="f11">The delegate to execute if this union represents a value of type <typeparamref name="T11"/>.</param>
		/// <param name="f12">The delegate to execute if this union represents a value of type <typeparamref name="T12"/>.</param>
		/// <param name="f13">The delegate to execute if this union represents a value of type <typeparamref name="T13"/>.</param>
		/// <param name="f14">The delegate to execute if this union represents a value of type <typeparamref name="T14"/>.</param>
		/// <param name="f15">The delegate to execute if this union represents a value of type <typeparamref name="T15"/>.</param>
		/// <param name="f16">The delegate to execute if this union represents a value of type <typeparamref name="T16"/>.</param>
		/// <param name="f17">The delegate to execute if this union represents a value of type <typeparamref name="T17"/>.</param>
		/// <param name="f18">The delegate to execute if this union represents a value of type <typeparamref name="T18"/>.</param>
        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18)
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
                case 10: 
                    if(f10 == null)
                    {
                        throw new ArgumentNullException(nameof(f10), $"The union is representing a value of type {typeof(T10).FullName} but no switch delegate was provided for its index.");
                    }
                    f10.Invoke(_value10);
                    return;
                case 11: 
                    if(f11 == null)
                    {
                        throw new ArgumentNullException(nameof(f11), $"The union is representing a value of type {typeof(T11).FullName} but no switch delegate was provided for its index.");
                    }
                    f11.Invoke(_value11);
                    return;
                case 12: 
                    if(f12 == null)
                    {
                        throw new ArgumentNullException(nameof(f12), $"The union is representing a value of type {typeof(T12).FullName} but no switch delegate was provided for its index.");
                    }
                    f12.Invoke(_value12);
                    return;
                case 13: 
                    if(f13 == null)
                    {
                        throw new ArgumentNullException(nameof(f13), $"The union is representing a value of type {typeof(T13).FullName} but no switch delegate was provided for its index.");
                    }
                    f13.Invoke(_value13);
                    return;
                case 14: 
                    if(f14 == null)
                    {
                        throw new ArgumentNullException(nameof(f14), $"The union is representing a value of type {typeof(T14).FullName} but no switch delegate was provided for its index.");
                    }
                    f14.Invoke(_value14);
                    return;
                case 15: 
                    if(f15 == null)
                    {
                        throw new ArgumentNullException(nameof(f15), $"The union is representing a value of type {typeof(T15).FullName} but no switch delegate was provided for its index.");
                    }
                    f15.Invoke(_value15);
                    return;
                case 16: 
                    if(f16 == null)
                    {
                        throw new ArgumentNullException(nameof(f16), $"The union is representing a value of type {typeof(T16).FullName} but no switch delegate was provided for its index.");
                    }
                    f16.Invoke(_value16);
                    return;
                case 17: 
                    if(f17 == null)
                    {
                        throw new ArgumentNullException(nameof(f17), $"The union is representing a value of type {typeof(T17).FullName} but no switch delegate was provided for its index.");
                    }
                    f17.Invoke(_value17);
                    return;
                case 18: 
                    if(f18 == null)
                    {
                        throw new ArgumentNullException(nameof(f18), $"The union is representing a value of type {typeof(T18).FullName} but no switch delegate was provided for its index.");
                    }
                    f18.Invoke(_value18);
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
		/// <param name="f10">The projection to execute if this union represents a value of type <typeparamref name="T10"/>.</param>
		/// <param name="f11">The projection to execute if this union represents a value of type <typeparamref name="T11"/>.</param>
		/// <param name="f12">The projection to execute if this union represents a value of type <typeparamref name="T12"/>.</param>
		/// <param name="f13">The projection to execute if this union represents a value of type <typeparamref name="T13"/>.</param>
		/// <param name="f14">The projection to execute if this union represents a value of type <typeparamref name="T14"/>.</param>
		/// <param name="f15">The projection to execute if this union represents a value of type <typeparamref name="T15"/>.</param>
		/// <param name="f16">The projection to execute if this union represents a value of type <typeparamref name="T16"/>.</param>
		/// <param name="f17">The projection to execute if this union represents a value of type <typeparamref name="T17"/>.</param>
		/// <param name="f18">The projection to execute if this union represents a value of type <typeparamref name="T18"/>.</param>
        /// <returns>The projected value.</returns>
        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18)
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
                case 10: 
                    if(f10 == null)
                    {
                        throw new ArgumentNullException(nameof(f10), $"The union is representing a value of type {typeof(T10).FullName} but no match projection was provided for its index.");
                    }
                    return f10.Invoke(_value10);
                case 11: 
                    if(f11 == null)
                    {
                        throw new ArgumentNullException(nameof(f11), $"The union is representing a value of type {typeof(T11).FullName} but no match projection was provided for its index.");
                    }
                    return f11.Invoke(_value11);
                case 12: 
                    if(f12 == null)
                    {
                        throw new ArgumentNullException(nameof(f12), $"The union is representing a value of type {typeof(T12).FullName} but no match projection was provided for its index.");
                    }
                    return f12.Invoke(_value12);
                case 13: 
                    if(f13 == null)
                    {
                        throw new ArgumentNullException(nameof(f13), $"The union is representing a value of type {typeof(T13).FullName} but no match projection was provided for its index.");
                    }
                    return f13.Invoke(_value13);
                case 14: 
                    if(f14 == null)
                    {
                        throw new ArgumentNullException(nameof(f14), $"The union is representing a value of type {typeof(T14).FullName} but no match projection was provided for its index.");
                    }
                    return f14.Invoke(_value14);
                case 15: 
                    if(f15 == null)
                    {
                        throw new ArgumentNullException(nameof(f15), $"The union is representing a value of type {typeof(T15).FullName} but no match projection was provided for its index.");
                    }
                    return f15.Invoke(_value15);
                case 16: 
                    if(f16 == null)
                    {
                        throw new ArgumentNullException(nameof(f16), $"The union is representing a value of type {typeof(T16).FullName} but no match projection was provided for its index.");
                    }
                    return f16.Invoke(_value16);
                case 17: 
                    if(f17 == null)
                    {
                        throw new ArgumentNullException(nameof(f17), $"The union is representing a value of type {typeof(T17).FullName} but no match projection was provided for its index.");
                    }
                    return f17.Invoke(_value17);
                case 18: 
                    if(f18 == null)
                    {
                        throw new ArgumentNullException(nameof(f18), $"The union is representing a value of type {typeof(T18).FullName} but no match projection was provided for its index.");
                    }
                    return f18.Invoke(_value18);
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
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
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
		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
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
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT9;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T10"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T10"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T10"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T10"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = IsT10 ? AsT10 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = default;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT10;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T11"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T11"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T11"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T11"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = IsT11 ? AsT11 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = default;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT11;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T12"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T12"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T12"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T12"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = IsT12 ? AsT12 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = default;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT12;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T13"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T13"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T13"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T13"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18> remainder)
		{
			value = IsT13 ? AsT13 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = default;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT13;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T14"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T14"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T14"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T14"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18> remainder)
		{
			value = IsT14 ? AsT14 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = default;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT14;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T15"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T15"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T15"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T15"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18> remainder)
		{
			value = IsT15 ? AsT15 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = default;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT15;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T16"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T16"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T16"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T16"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18> remainder)
		{
			value = IsT16 ? AsT16 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = default;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT16;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T17"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T17"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T17"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T17"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18> remainder)
		{
			value = IsT17 ? AsT17 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = default;
                    break;
                case 18:
                    remainder = AsT18;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT17;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T18"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T18"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T18"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T18"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = IsT18 ? AsT18 : default;
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
                    remainder = AsT9;
                    break;
                case 10:
                    remainder = AsT10;
                    break;
                case 11:
                    remainder = AsT11;
                    break;
                case 12:
                    remainder = AsT12;
                    break;
                case 13:
                    remainder = AsT13;
                    break;
                case 14:
                    remainder = AsT14;
                    break;
                case 15:
                    remainder = AsT15;
                    break;
                case 16:
                    remainder = AsT16;
                    break;
                case 17:
                    remainder = AsT17;
                    break;
                case 18:
                    remainder = default;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT18;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> other)
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
                case 10: 
                    return Equals(_value10, other._value10);
                case 11: 
                    return Equals(_value11, other._value11);
                case 12: 
                    return Equals(_value12, other._value12);
                case 13: 
                    return Equals(_value13, other._value13);
                case 14: 
                    return Equals(_value14, other._value14);
                case 15: 
                    return Equals(_value15, other._value15);
                case 16: 
                    return Equals(_value16, other._value16);
                case 17: 
                    return Equals(_value17, other._value17);
                case 18: 
                    return Equals(_value18, other._value18);
                default:
                    return false;
            };
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            obj != null && (ReferenceEquals(this, obj) || obj is OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> o && Equals(o));

        /// <inheritdoc/>
        public override string ToString()
        {
            switch(_index)
            {
                case 0:
                    return FormatValue(_value0);
                case 1:
                    return FormatValue(_value1);
                case 2:
                    return FormatValue(_value2);
                case 3:
                    return FormatValue(_value3);
                case 4:
                    return FormatValue(_value4);
                case 5:
                    return FormatValue(_value5);
                case 6:
                    return FormatValue(_value6);
                case 7:
                    return FormatValue(_value7);
                case 8:
                    return FormatValue(_value8);
                case 9:
                    return FormatValue(_value9);
                case 10:
                    return FormatValue(_value10);
                case 11:
                    return FormatValue(_value11);
                case 12:
                    return FormatValue(_value12);
                case 13:
                    return FormatValue(_value13);
                case 14:
                    return FormatValue(_value14);
                case 15:
                    return FormatValue(_value15);
                case 16:
                    return FormatValue(_value16);
                case 17:
                    return FormatValue(_value17);
                case 18:
                    return FormatValue(_value18);
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
                    case 10:
                        hashCode = _value10?.GetHashCode();
                        break;
                    case 11:
                        hashCode = _value11?.GetHashCode();
                        break;
                    case 12:
                        hashCode = _value12?.GetHashCode();
                        break;
                    case 13:
                        hashCode = _value13?.GetHashCode();
                        break;
                    case 14:
                        hashCode = _value14?.GetHashCode();
                        break;
                    case 15:
                        hashCode = _value15?.GetHashCode();
                        break;
                    case 16:
                        hashCode = _value16?.GetHashCode();
                        break;
                    case 17:
                        hashCode = _value17?.GetHashCode();
                        break;
                    case 18:
                        hashCode = _value18?.GetHashCode();
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
