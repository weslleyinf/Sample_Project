using Sample.Domain.ValueObjects.Base;

namespace Sample.ValueObjects
{
    public abstract class PriceValueObject : ValueObject<PriceValueObject>
    {
        public decimal Value { get; }

        public string Sign { get; }

        public PriceValueObject(decimal value, string sign)
        {
            Value = value;
            Sign = string.IsNullOrEmpty(sign) ? sign : "R$";
        }

        protected override bool EqualsCore(PriceValueObject other) => Value == other.Value && Sign.Equals(other.Sign);

        protected override int GetHashCodeCore() => ($"{ Sign }{ Value }").GetHashCode(); 

        public override string ToString() => $"{ Sign } { Value.ToString("N2") }";
    }
}
