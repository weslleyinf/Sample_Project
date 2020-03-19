using Sample.ValueObjects;

namespace Sample.Domain.Product
{
    public class ProductId : InternalIdValueObject
    {
        public ProductId(int id) : base(id) { }
    }
}
