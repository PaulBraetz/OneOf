using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 24 types.
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
    /// <typeparam name="T19">The 19th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T20">The 21st type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T21">The 22nd type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T22">The 22th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T23">The 23th type of value this type of union is able to represent.</typeparam>
    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : IOneOf
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
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly int _index;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="input">The union based on which to set the type and value represented by this union.</param>
        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> input)
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
                case 19: 
                    _value19 = input.AsT19; 
                    break;
                case 20: 
                    _value20 = input.AsT20; 
                    break;
                case 21: 
                    _value21 = input.AsT21; 
                    break;
                case 22: 
                    _value22 = input.AsT22; 
                    break;
                case 23: 
                    _value23 = input.AsT23; 
                    break;
                default: 
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
        
        /// <summary>
        /// Gets the type of value represented by this union.
        /// </summary>
        public Type GetRepresentedType()=>
            _index switch
            {
                0 => typeof(T0),
                1 => typeof(T1),
                2 => typeof(T2),
                3 => typeof(T3),
                4 => typeof(T4),
                5 => typeof(T5),
                6 => typeof(T6),
                7 => typeof(T7),
                8 => typeof(T8),
                9 => typeof(T9),
                10 => typeof(T10),
                11 => typeof(T11),
                12 => typeof(T12),
                13 => typeof(T13),
                14 => typeof(T14),
                15 => typeof(T15),
                16 => typeof(T16),
                17 => typeof(T17),
                18 => typeof(T18),
                19 => typeof(T19),
                20 => typeof(T20),
                21 => typeof(T21),
                22 => typeof(T22),
                23 => typeof(T23),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

        /// <summary>
        /// Gets the value represented by this union.
        /// </summary>
        public object Value =>
            _index switch
            {
                0 => _value0,
                1 => _value1,
                2 => _value2,
                3 => _value3,
                4 => _value4,
                5 => _value5,
                6 => _value6,
                7 => _value7,
                8 => _value8,
                9 => _value9,
                10 => _value10,
                11 => _value11,
                12 => _value12,
                13 => _value13,
                14 => _value14,
                15 => _value15,
                16 => _value16,
                17 => _value17,
                18 => _value18,
                19 => _value19,
                20 => _value20,
                21 => _value21,
                22 => _value22,
                23 => _value23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

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
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T19"/>.
        /// </summary>
        public bool IsT19 => _index == 19;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T20"/>.
        /// </summary>
        public bool IsT20 => _index == 20;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T21"/>.
        /// </summary>
        public bool IsT21 => _index == 21;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T22"/>.
        /// </summary>
        public bool IsT22 => _index == 22;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T23"/>.
        /// </summary>
        public bool IsT23 => _index == 23;

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
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T19"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T19 AsT19 =>
            _index == 19 ?
                _value19 :
                throw new InvalidOperationException($"Cannot return the value represented as T19 ({typeof(T19).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T20"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T20 AsT20 =>
            _index == 20 ?
                _value20 :
                throw new InvalidOperationException($"Cannot return the value represented as T20 ({typeof(T20).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T21"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T21 AsT21 =>
            _index == 21 ?
                _value21 :
                throw new InvalidOperationException($"Cannot return the value represented as T21 ({typeof(T21).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T22"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T22 AsT22 =>
            _index == 22 ?
                _value22 :
                throw new InvalidOperationException($"Cannot return the value represented as T22 ({typeof(T22).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T23"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T23 AsT23 =>
            _index == 23 ?
                _value23 :
                throw new InvalidOperationException($"Cannot return the value represented as T23 ({typeof(T23).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");

        

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
		/// <param name="f19">The delegate to execute if this union represents a value of type <typeparamref name="T19"/>.</param>
		/// <param name="f20">The delegate to execute if this union represents a value of type <typeparamref name="T20"/>.</param>
		/// <param name="f21">The delegate to execute if this union represents a value of type <typeparamref name="T21"/>.</param>
		/// <param name="f22">The delegate to execute if this union represents a value of type <typeparamref name="T22"/>.</param>
		/// <param name="f23">The delegate to execute if this union represents a value of type <typeparamref name="T23"/>.</param>
        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23)
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
                case 19: 
                    if(f19 == null)
                    {
                        throw new ArgumentNullException(nameof(f19), $"The union is representing a value of type {typeof(T19).FullName} but no switch delegate was provided for its index.");
                    }
                    f19.Invoke(_value19);
                    return;
                case 20: 
                    if(f20 == null)
                    {
                        throw new ArgumentNullException(nameof(f20), $"The union is representing a value of type {typeof(T20).FullName} but no switch delegate was provided for its index.");
                    }
                    f20.Invoke(_value20);
                    return;
                case 21: 
                    if(f21 == null)
                    {
                        throw new ArgumentNullException(nameof(f21), $"The union is representing a value of type {typeof(T21).FullName} but no switch delegate was provided for its index.");
                    }
                    f21.Invoke(_value21);
                    return;
                case 22: 
                    if(f22 == null)
                    {
                        throw new ArgumentNullException(nameof(f22), $"The union is representing a value of type {typeof(T22).FullName} but no switch delegate was provided for its index.");
                    }
                    f22.Invoke(_value22);
                    return;
                case 23: 
                    if(f23 == null)
                    {
                        throw new ArgumentNullException(nameof(f23), $"The union is representing a value of type {typeof(T23).FullName} but no switch delegate was provided for its index.");
                    }
                    f23.Invoke(_value23);
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
		/// <param name="f19">The projection to execute if this union represents a value of type <typeparamref name="T19"/>.</param>
		/// <param name="f20">The projection to execute if this union represents a value of type <typeparamref name="T20"/>.</param>
		/// <param name="f21">The projection to execute if this union represents a value of type <typeparamref name="T21"/>.</param>
		/// <param name="f22">The projection to execute if this union represents a value of type <typeparamref name="T22"/>.</param>
		/// <param name="f23">The projection to execute if this union represents a value of type <typeparamref name="T23"/>.</param>
        /// <returns>The projected value.</returns>
        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23)
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
                case 19: 
                    if(f19 == null)
                    {
                        throw new ArgumentNullException(nameof(f19), $"The union is representing a value of type {typeof(T19).FullName} but no match projection was provided for its index.");
                    }
                    return f19.Invoke(_value19);
                case 20: 
                    if(f20 == null)
                    {
                        throw new ArgumentNullException(nameof(f20), $"The union is representing a value of type {typeof(T20).FullName} but no match projection was provided for its index.");
                    }
                    return f20.Invoke(_value20);
                case 21: 
                    if(f21 == null)
                    {
                        throw new ArgumentNullException(nameof(f21), $"The union is representing a value of type {typeof(T21).FullName} but no match projection was provided for its index.");
                    }
                    return f21.Invoke(_value21);
                case 22: 
                    if(f22 == null)
                    {
                        throw new ArgumentNullException(nameof(f22), $"The union is representing a value of type {typeof(T22).FullName} but no match projection was provided for its index.");
                    }
                    return f22.Invoke(_value22);
                case 23: 
                    if(f23 == null)
                    {
                        throw new ArgumentNullException(nameof(f23), $"The union is representing a value of type {typeof(T23).FullName} but no match projection was provided for its index.");
                    }
                    return f23.Invoke(_value23);
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
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT0 ? AsT0 : default;
            remainder = _index switch
            {
                0 => default,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT1 ? AsT1 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => default,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT2 ? AsT2 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => default,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT3 ? AsT3 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => default,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT4 ? AsT4 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => default,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT5 ? AsT5 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => default,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT6 ? AsT6 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => default,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT7 ? AsT7 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => default,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT8 ? AsT8 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => default,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT9 ? AsT9 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => default,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT10 ? AsT10 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => default,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT11 ? AsT11 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => default,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT12 ? AsT12 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => default,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT13 ? AsT13 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => default,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT14 ? AsT14 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => default,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT15 ? AsT15 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => default,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT16 ? AsT16 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => default,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT17 ? AsT17 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => default,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
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
		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23> remainder)
		{
			value = IsT18 ? AsT18 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => default,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
			return this.IsT18;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T19"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T19"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T19"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T19"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23> remainder)
		{
			value = IsT19 ? AsT19 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => default,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
			return this.IsT19;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T20"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T20"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T20"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T20"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23> remainder)
		{
			value = IsT20 ? AsT20 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => default,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
			return this.IsT20;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T21"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T21"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T21"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T21"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23> remainder)
		{
			value = IsT21 ? AsT21 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => default,
                22 => AsT22,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
			return this.IsT21;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T22"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T22"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T22"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T22"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23> remainder)
		{
			value = IsT22 ? AsT22 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => default,
                23 => AsT23,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
			return this.IsT22;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T23"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T23"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T23"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T23"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = IsT23 ? AsT23 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => default,
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
			return this.IsT23;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other) =>
            _index == other._index &&
            _index switch
            {
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                2 => Equals(_value2, other._value2),
                3 => Equals(_value3, other._value3),
                4 => Equals(_value4, other._value4),
                5 => Equals(_value5, other._value5),
                6 => Equals(_value6, other._value6),
                7 => Equals(_value7, other._value7),
                8 => Equals(_value8, other._value8),
                9 => Equals(_value9, other._value9),
                10 => Equals(_value10, other._value10),
                11 => Equals(_value11, other._value11),
                12 => Equals(_value12, other._value12),
                13 => Equals(_value13, other._value13),
                14 => Equals(_value14, other._value14),
                15 => Equals(_value15, other._value15),
                16 => Equals(_value16, other._value16),
                17 => Equals(_value17, other._value17),
                18 => Equals(_value18, other._value18),
                19 => Equals(_value19, other._value19),
                20 => Equals(_value20, other._value20),
                21 => Equals(_value21, other._value21),
                22 => Equals(_value22, other._value22),
                23 => Equals(_value23, other._value23),
                _ => false
            };

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            obj != null && (ReferenceEquals(this, obj) || obj is OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> o && Equals(o));

        /// <inheritdoc/>
        public override string ToString() =>
            _index switch {
                0 => FormatValue(_value0),
                1 => FormatValue(_value1),
                2 => FormatValue(_value2),
                3 => FormatValue(_value3),
                4 => FormatValue(_value4),
                5 => FormatValue(_value5),
                6 => FormatValue(_value6),
                7 => FormatValue(_value7),
                8 => FormatValue(_value8),
                9 => FormatValue(_value9),
                10 => FormatValue(_value10),
                11 => FormatValue(_value11),
                12 => FormatValue(_value12),
                13 => FormatValue(_value13),
                14 => FormatValue(_value14),
                15 => FormatValue(_value15),
                16 => FormatValue(_value16),
                17 => FormatValue(_value17),
                18 => FormatValue(_value18),
                19 => FormatValue(_value19),
                20 => FormatValue(_value20),
                21 => FormatValue(_value21),
                22 => FormatValue(_value22),
                23 => FormatValue(_value23),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
                    2 => _value2?.GetHashCode(),
                    3 => _value3?.GetHashCode(),
                    4 => _value4?.GetHashCode(),
                    5 => _value5?.GetHashCode(),
                    6 => _value6?.GetHashCode(),
                    7 => _value7?.GetHashCode(),
                    8 => _value8?.GetHashCode(),
                    9 => _value9?.GetHashCode(),
                    10 => _value10?.GetHashCode(),
                    11 => _value11?.GetHashCode(),
                    12 => _value12?.GetHashCode(),
                    13 => _value13?.GetHashCode(),
                    14 => _value14?.GetHashCode(),
                    15 => _value15?.GetHashCode(),
                    16 => _value16?.GetHashCode(),
                    17 => _value17?.GetHashCode(),
                    18 => _value18?.GetHashCode(),
                    19 => _value19?.GetHashCode(),
                    20 => _value20?.GetHashCode(),
                    21 => _value21?.GetHashCode(),
                    22 => _value22?.GetHashCode(),
                    23 => _value23?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode*397) ^ _index;
            }
        }
    }
}
