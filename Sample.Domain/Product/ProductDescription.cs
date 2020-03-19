using Sample.ValueObjects;

namespace Sample.Domain.Product
{
    public class ProductDescription : DescriptionValueObject
    {
        public ProductDescription(string descriptionText) : base(descriptionText) { }
    }
}
