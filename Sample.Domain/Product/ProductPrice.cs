using Sample.ValueObjects;

namespace Sample.Domain.Product
{
    public class ProductPrice : PriceValueObject
    {
        public ProductPrice(decimal value, string sign) : base(value, sign) { }
    }
}
