using Sample.ValueObjects;

namespace Sample.Domain.Category
{
    public class CategoryId : InternalIdValueObject
    {
        public CategoryId(int id) : base(id) { }
    }
}
