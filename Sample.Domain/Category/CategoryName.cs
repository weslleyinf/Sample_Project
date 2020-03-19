using Sample.ValueObjects;

namespace Sample.Domain.Category
{
    public class CategoryName : NameValueObject
    {
        public CategoryName(string fullName) : base(fullName) { }
    }
}
