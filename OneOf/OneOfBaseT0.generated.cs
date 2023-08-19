using System;
using static OneOf.Functions;

namespace OneOf
{
    /// <summary>
    /// Represents a discriminated union of 1 type.
    /// </summary>
    /// <typeparam name="T0">The first type of value this type of union is able to represent.</typeparam>
    public class OneOfBase<T0> : IOneOf
    {
        readonly T0 _value0;
        readonly int _index;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="input">The union based on which to set the type and value represented by this union.</param>
        protected OneOfBase(OneOf<T0> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: 
                    _value0 = input.AsT0; 
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

        

        

        bool Equals(OneOfBase<T0> other)
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
            obj != null && (ReferenceEquals(this, obj) || obj is OneOfBase<T0> o && Equals(o));

        /// <inheritdoc/>
        public override string ToString()
        {
            switch(_index)
            {
                case 0:
                    return _value0?.ToString();
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
    }
}
