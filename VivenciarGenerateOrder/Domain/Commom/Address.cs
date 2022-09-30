using VivenciarGenerateOrder.Domain.Enum;

namespace VivenciarGenerateOrder.Domain.Commom
{
    public class Address : ValueObject<Address>
    {
        public Address(string street, string number, string moreIfo, string city, BrazilianStates state, string zipCode)
        {
            Street = street;
            Number = number;
            MoreIfo = moreIfo;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string MoreIfo { get; private set; }
        public string City { get; private set; }
        public BrazilianStates State { get; private set; }
        public string ZipCode { get; private set; }

        protected override bool EqualsCore(Address other)
        {
            return ToString() == other.ToString();
        }

        protected override int GetHashCodeCore()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Street))
                return "";

            return $"{Street}, {Number} / {MoreIfo}";
        }
    }
}
