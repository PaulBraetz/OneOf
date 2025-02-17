using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 29 types.
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
    /// <typeparam name="T24">The 24th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T25">The 25th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T26">The 26th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T27">The 27th type of value this type of union is able to represent.</typeparam>
    /// <typeparam name="T28">The 28th type of value this type of union is able to represent.</typeparam>
    public readonly struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> : IOneOf, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>
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
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default, T8 value8 = default, T9 value9 = default, T10 value10 = default, T11 value11 = default, T12 value12 = default, T13 value13 = default, T14 value14 = default, T15 value15 = default, T16 value16 = default, T17 value17 = default, T18 value18 = default, T19 value19 = default, T20 value20 = default, T21 value21 = default, T22 value22 = default, T23 value23 = default, T24 value24 = default, T25 value25 = default, T26 value26 = default, T27 value27 = default, T28 value28 = default)
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
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
            _value26 = value26;
            _value27 = value27;
            _value28 = value28;
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
                case 19: 
                    return typeof(T19);
                case 20: 
                    return typeof(T20);
                case 21: 
                    return typeof(T21);
                case 22: 
                    return typeof(T22);
                case 23: 
                    return typeof(T23);
                case 24: 
                    return typeof(T24);
                case 25: 
                    return typeof(T25);
                case 26: 
                    return typeof(T26);
                case 27: 
                    return typeof(T27);
                case 28: 
                    return typeof(T28);
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
                    case 19: 
                        return _value19;
                    case 20: 
                        return _value20;
                    case 21: 
                        return _value21;
                    case 22: 
                        return _value22;
                    case 23: 
                        return _value23;
                    case 24: 
                        return _value24;
                    case 25: 
                        return _value25;
                    case 26: 
                        return _value26;
                    case 27: 
                        return _value27;
                    case 28: 
                        return _value28;
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
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T24"/>.
        /// </summary>
        public bool IsT24 => _index == 24;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T25"/>.
        /// </summary>
        public bool IsT25 => _index == 25;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T26"/>.
        /// </summary>
        public bool IsT26 => _index == 26;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T27"/>.
        /// </summary>
        public bool IsT27 => _index == 27;
        /// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name="T28"/>.
        /// </summary>
        public bool IsT28 => _index == 28;

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
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T24"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T24 AsT24 =>
            _index == 24 ?
                _value24 :
                throw new InvalidOperationException($"Cannot return the value represented as T24 ({typeof(T24).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T25"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T25 AsT25 =>
            _index == 25 ?
                _value25 :
                throw new InvalidOperationException($"Cannot return the value represented as T25 ({typeof(T25).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T26"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T26 AsT26 =>
            _index == 26 ?
                _value26 :
                throw new InvalidOperationException($"Cannot return the value represented as T26 ({typeof(T26).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T27"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T27 AsT27 =>
            _index == 27 ?
                _value27 :
                throw new InvalidOperationException($"Cannot return the value represented as T27 ({typeof(T27).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");
        /// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name="T28"/>.
        /// Otherwise, an <see cref="InvalidOperationException"/> will be thrown.
        /// </summary>
        public T28 AsT28 =>
            _index == 28 ?
                _value28 :
                throw new InvalidOperationException($"Cannot return the value represented as T28 ({typeof(T28).FullName}) because the type of value represented is T{_index} ({GetRepresentedType().FullName})");

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T0 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(0, value0: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T1 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(1, value1: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T2 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(2, value2: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T3 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(3, value3: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T4 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(4, value4: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T5 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(5, value5: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T6 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(6, value6: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T7 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(7, value7: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T8 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(8, value8: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T9 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(9, value9: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T10 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(10, value10: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T11 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(11, value11: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T12 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(12, value12: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T13 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(13, value13: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T14 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(14, value14: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T15 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(15, value15: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T16 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(16, value16: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T17 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(17, value17: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T18 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(18, value18: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T19 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(19, value19: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T20 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(20, value20: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T21 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(21, value21: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T22 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(22, value22: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T23 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(23, value23: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T24 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(24, value24: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T25 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(25, value25: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T26 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(26, value26: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T27 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(27, value27: value);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T28 value) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(28, value28: value);

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
		/// <param name="f24">The delegate to execute if this union represents a value of type <typeparamref name="T24"/>.</param>
		/// <param name="f25">The delegate to execute if this union represents a value of type <typeparamref name="T25"/>.</param>
		/// <param name="f26">The delegate to execute if this union represents a value of type <typeparamref name="T26"/>.</param>
		/// <param name="f27">The delegate to execute if this union represents a value of type <typeparamref name="T27"/>.</param>
		/// <param name="f28">The delegate to execute if this union represents a value of type <typeparamref name="T28"/>.</param>
        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28)
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
                case 24: 
                    if(f24 == null)
                    {
                        throw new ArgumentNullException(nameof(f24), $"The union is representing a value of type {typeof(T24).FullName} but no switch delegate was provided for its index.");
                    }
                    f24.Invoke(_value24);
                    return;
                case 25: 
                    if(f25 == null)
                    {
                        throw new ArgumentNullException(nameof(f25), $"The union is representing a value of type {typeof(T25).FullName} but no switch delegate was provided for its index.");
                    }
                    f25.Invoke(_value25);
                    return;
                case 26: 
                    if(f26 == null)
                    {
                        throw new ArgumentNullException(nameof(f26), $"The union is representing a value of type {typeof(T26).FullName} but no switch delegate was provided for its index.");
                    }
                    f26.Invoke(_value26);
                    return;
                case 27: 
                    if(f27 == null)
                    {
                        throw new ArgumentNullException(nameof(f27), $"The union is representing a value of type {typeof(T27).FullName} but no switch delegate was provided for its index.");
                    }
                    f27.Invoke(_value27);
                    return;
                case 28: 
                    if(f28 == null)
                    {
                        throw new ArgumentNullException(nameof(f28), $"The union is representing a value of type {typeof(T28).FullName} but no switch delegate was provided for its index.");
                    }
                    f28.Invoke(_value28);
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
		/// <param name="f24">The projection to execute if this union represents a value of type <typeparamref name="T24"/>.</param>
		/// <param name="f25">The projection to execute if this union represents a value of type <typeparamref name="T25"/>.</param>
		/// <param name="f26">The projection to execute if this union represents a value of type <typeparamref name="T26"/>.</param>
		/// <param name="f27">The projection to execute if this union represents a value of type <typeparamref name="T27"/>.</param>
		/// <param name="f28">The projection to execute if this union represents a value of type <typeparamref name="T28"/>.</param>
        /// <returns>The projected value.</returns>
        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28)
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
                case 24: 
                    if(f24 == null)
                    {
                        throw new ArgumentNullException(nameof(f24), $"The union is representing a value of type {typeof(T24).FullName} but no match projection was provided for its index.");
                    }
                    return f24.Invoke(_value24);
                case 25: 
                    if(f25 == null)
                    {
                        throw new ArgumentNullException(nameof(f25), $"The union is representing a value of type {typeof(T25).FullName} but no match projection was provided for its index.");
                    }
                    return f25.Invoke(_value25);
                case 26: 
                    if(f26 == null)
                    {
                        throw new ArgumentNullException(nameof(f26), $"The union is representing a value of type {typeof(T26).FullName} but no match projection was provided for its index.");
                    }
                    return f26.Invoke(_value26);
                case 27: 
                    if(f27 == null)
                    {
                        throw new ArgumentNullException(nameof(f27), $"The union is representing a value of type {typeof(T27).FullName} but no match projection was provided for its index.");
                    }
                    return f27.Invoke(_value27);
                case 28: 
                    if(f28 == null)
                    {
                        throw new ArgumentNullException(nameof(f28), $"The union is representing a value of type {typeof(T28).FullName} but no match projection was provided for its index.");
                    }
                    return f28.Invoke(_value28);
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT0(T0 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT1(T1 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT2(T2 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT3(T3 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT4(T4 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT5(T5 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT6(T6 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT7(T7 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT8(T8 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT9(T9 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT10(T10 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT11(T11 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT12(T12 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT13(T13 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT14(T14 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT15(T15 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT16(T16 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT17(T17 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT18(T18 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT19(T19 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT20(T20 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT21(T21 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT22(T22 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT23(T23 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT24(T24 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT25(T25 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT26(T26 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT27(T27 value) => value;
        /// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name="value">The value to wrap inside a discriminated union instance.</param>
        /// <returns>A union representing the value provided.</returns>
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> FromT28(T28 value) => value;

        
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
        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT0<TResult>(Func<T0, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT1<TResult>(Func<T1, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT2<TResult>(Func<T2, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT3<TResult>(Func<T3, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT4<TResult>(Func<T4, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT5<TResult>(Func<T5, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT6<TResult>(Func<T6, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT7<TResult>(Func<T7, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT8<TResult>(Func<T8, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
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
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT9<TResult>(Func<T9, TResult> mapFunc)
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
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its eleventh type (<typeparamref name="T10"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T10"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the eleventh type (<typeparamref name="T10"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT10<TResult>(Func<T10, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return mapFunc.Invoke(AsT10);
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its twelfth type (<typeparamref name="T11"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T11"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the twelfth type (<typeparamref name="T11"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT11<TResult>(Func<T11, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return mapFunc.Invoke(AsT11);
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 12th type (<typeparamref name="T12"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T12"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 12th type (<typeparamref name="T12"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT12<TResult>(Func<T12, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return mapFunc.Invoke(AsT12);
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 13th type (<typeparamref name="T13"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T13"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 13th type (<typeparamref name="T13"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT13<TResult>(Func<T13, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return mapFunc.Invoke(AsT13);
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 14th type (<typeparamref name="T14"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T14"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 14th type (<typeparamref name="T14"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT14<TResult>(Func<T14, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return mapFunc.Invoke(AsT14);
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 15th type (<typeparamref name="T15"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T15"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 15th type (<typeparamref name="T15"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT15<TResult>(Func<T15, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return mapFunc.Invoke(AsT15);
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 16th type (<typeparamref name="T16"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T16"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 16th type (<typeparamref name="T16"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT16<TResult>(Func<T16, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return mapFunc.Invoke(AsT16);
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 17th type (<typeparamref name="T17"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T17"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 17th type (<typeparamref name="T17"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT17<TResult>(Func<T17, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return mapFunc.Invoke(AsT17);
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 18th type (<typeparamref name="T18"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T18"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 18th type (<typeparamref name="T18"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT18<TResult>(Func<T18, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return mapFunc.Invoke(AsT18);
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 19th type (<typeparamref name="T19"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T19"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 19th type (<typeparamref name="T19"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult, T20, T21, T22, T23, T24, T25, T26, T27, T28> MapT19<TResult>(Func<T19, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return mapFunc.Invoke(AsT19);
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 21st type (<typeparamref name="T20"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T20"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 21st type (<typeparamref name="T20"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TResult, T21, T22, T23, T24, T25, T26, T27, T28> MapT20<TResult>(Func<T20, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return mapFunc.Invoke(AsT20);
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 22nd type (<typeparamref name="T21"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T21"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 22nd type (<typeparamref name="T21"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TResult, T22, T23, T24, T25, T26, T27, T28> MapT21<TResult>(Func<T21, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return mapFunc.Invoke(AsT21);
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 22th type (<typeparamref name="T22"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T22"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 22th type (<typeparamref name="T22"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TResult, T23, T24, T25, T26, T27, T28> MapT22<TResult>(Func<T22, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return mapFunc.Invoke(AsT22);
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 23th type (<typeparamref name="T23"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T23"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 23th type (<typeparamref name="T23"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TResult, T24, T25, T26, T27, T28> MapT23<TResult>(Func<T23, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return mapFunc.Invoke(AsT23);
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 24th type (<typeparamref name="T24"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T24"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 24th type (<typeparamref name="T24"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TResult, T25, T26, T27, T28> MapT24<TResult>(Func<T24, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return mapFunc.Invoke(AsT24);
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 25th type (<typeparamref name="T25"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T25"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 25th type (<typeparamref name="T25"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TResult, T26, T27, T28> MapT25<TResult>(Func<T25, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return mapFunc.Invoke(AsT25);
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 26th type (<typeparamref name="T26"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T26"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 26th type (<typeparamref name="T26"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TResult, T27, T28> MapT26<TResult>(Func<T26, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return mapFunc.Invoke(AsT26);
                case 27:
                    return AsT27;
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 27th type (<typeparamref name="T27"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T27"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 27th type (<typeparamref name="T27"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TResult, T28> MapT27<TResult>(Func<T27, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return mapFunc.Invoke(AsT27);
                case 28:
                    return AsT28;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }
            
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its 28th type (<typeparamref name="T28"/>) 
        /// mapped to <typeparamref name="TResult"/>. If the union is representing
        /// a corresponding value, it will be mapped using the projection provided.
        /// </summary>
        /// <param name="mapFunc">
        /// The delegate used to map this unions value onto <typeparamref name="TResult"/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name="TResult">The type to map <typeparamref name="T28"/> onto.</typeparam>
        /// <returns>
        /// A new union instance of the same arity, representing the same value, 
        /// but with the 28th type (<typeparamref name="T28"/>) 
        /// mapped onto <typeparamref name="TResult"/>.
        /// </returns>
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TResult> MapT28<TResult>(Func<T28, TResult> mapFunc)
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
                    return AsT9;
                case 10:
                    return AsT10;
                case 11:
                    return AsT11;
                case 12:
                    return AsT12;
                case 13:
                    return AsT13;
                case 14:
                    return AsT14;
                case 15:
                    return AsT15;
                case 16:
                    return AsT16;
                case 17:
                    return AsT17;
                case 18:
                    return AsT18;
                case 19:
                    return AsT19;
                case 20:
                    return AsT20;
                case 21:
                    return AsT21;
                case 22:
                    return AsT22;
                case 23:
                    return AsT23;
                case 24:
                    return AsT24;
                case 25:
                    return AsT25;
                case 26:
                    return AsT26;
                case 27:
                    return AsT27;
                case 28:
                    return mapFunc.Invoke(AsT28);
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
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
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
		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
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
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
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
		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = IsT19 ? AsT19 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = default;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
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
		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = IsT20 ? AsT20 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = default;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
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
		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = IsT21 ? AsT21 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = default;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
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
		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = IsT22 ? AsT22 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = default;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
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
		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28> remainder)
		{
			value = IsT23 ? AsT23 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = default;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT23;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T24"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T24"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T24"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T24"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28> remainder)
		{
			value = IsT24 ? AsT24 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = default;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT24;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T25"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T25"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T25"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T25"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28> remainder)
		{
			value = IsT25 ? AsT25 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = default;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT25;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T26"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T26"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T26"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T26"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28> remainder)
		{
			value = IsT26 ? AsT26 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = default;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT26;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T27"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T27"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T27"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T27"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT27(out T27 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28> remainder)
		{
			value = IsT27 ? AsT27 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = default;
                    break;
                case 28:
                    remainder = AsT28;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT27;
		}
        
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name="value">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name="T28"/>; otherwise, <see langword="default"/>.
        /// </param>
        /// <param name="remainder">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name="T28"/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name="T28"/>; otherwise, 
        /// <see langword="default"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if this union represents a value of type <typeparamref name="T28"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
		public bool TryPickT28(out T28 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = IsT28 ? AsT28 : default;
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
                    remainder = AsT18;
                    break;
                case 19:
                    remainder = AsT19;
                    break;
                case 20:
                    remainder = AsT20;
                    break;
                case 21:
                    remainder = AsT21;
                    break;
                case 22:
                    remainder = AsT22;
                    break;
                case 23:
                    remainder = AsT23;
                    break;
                case 24:
                    remainder = AsT24;
                    break;
                case 25:
                    remainder = AsT25;
                    break;
                case 26:
                    remainder = AsT26;
                    break;
                case 27:
                    remainder = AsT27;
                    break;
                case 28:
                    remainder = default;
                    break;
                default:
                    throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            };
			return this.IsT28;
		}

        /// <inheritdoc/>
        public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> other)
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
                case 19: 
                    return Equals(_value19, other._value19);
                case 20: 
                    return Equals(_value20, other._value20);
                case 21: 
                    return Equals(_value21, other._value21);
                case 22: 
                    return Equals(_value22, other._value22);
                case 23: 
                    return Equals(_value23, other._value23);
                case 24: 
                    return Equals(_value24, other._value24);
                case 25: 
                    return Equals(_value25, other._value25);
                case 26: 
                    return Equals(_value26, other._value26);
                case 27: 
                    return Equals(_value27, other._value27);
                case 28: 
                    return Equals(_value28, other._value28);
                default:
                    return false;
            };
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> o && Equals(o);

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
                case 10:
                    return _value10?.ToString();
                case 11:
                    return _value11?.ToString();
                case 12:
                    return _value12?.ToString();
                case 13:
                    return _value13?.ToString();
                case 14:
                    return _value14?.ToString();
                case 15:
                    return _value15?.ToString();
                case 16:
                    return _value16?.ToString();
                case 17:
                    return _value17?.ToString();
                case 18:
                    return _value18?.ToString();
                case 19:
                    return _value19?.ToString();
                case 20:
                    return _value20?.ToString();
                case 21:
                    return _value21?.ToString();
                case 22:
                    return _value22?.ToString();
                case 23:
                    return _value23?.ToString();
                case 24:
                    return _value24?.ToString();
                case 25:
                    return _value25?.ToString();
                case 26:
                    return _value26?.ToString();
                case 27:
                    return _value27?.ToString();
                case 28:
                    return _value28?.ToString();
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
                    case 19:
                        hashCode = _value19?.GetHashCode();
                        break;
                    case 20:
                        hashCode = _value20?.GetHashCode();
                        break;
                    case 21:
                        hashCode = _value21?.GetHashCode();
                        break;
                    case 22:
                        hashCode = _value22?.GetHashCode();
                        break;
                    case 23:
                        hashCode = _value23?.GetHashCode();
                        break;
                    case 24:
                        hashCode = _value24?.GetHashCode();
                        break;
                    case 25:
                        hashCode = _value25?.GetHashCode();
                        break;
                    case 26:
                        hashCode = _value26?.GetHashCode();
                        break;
                    case 27:
                        hashCode = _value27?.GetHashCode();
                        break;
                    case 28:
                        hashCode = _value28?.GetHashCode();
                        break;
                    default:
                        hashCode = null;
                        break;
                };

                return ((hashCode ?? 0) * 397) ^ _index;
            }
        }
        public static bool operator ==(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> a,OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> b) =>
            a.Equals(b);
        public static bool operator !=(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> a,OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> b) =>
            !(a == b);
    }
}
