namespace VivenciarGenerateOrder.Domain.Commom
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object valueObject)
        {
            var _valueObject = valueObject as T;

            if (ReferenceEquals(_valueObject, null))
            {
                return false;
            }

            return EqualsCore(_valueObject);
        }

        protected abstract bool EqualsCore(T other);

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected abstract int GetHashCodeCore();

        public static bool operator ==(ValueObject<T> objectA, ValueObject<T> objectB)
        {
            if (ReferenceEquals(objectA, null) && ReferenceEquals(objectB, null))
                return true;

            if (ReferenceEquals(objectA, null) || ReferenceEquals(objectB, null))
                return false;

            return objectA.Equals(objectB);
        }

        public static bool operator !=(ValueObject<T> objectA, ValueObject<T> objctB)
        {
            return !(objectA == objctB);
        }
    }
}
