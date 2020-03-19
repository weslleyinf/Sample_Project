using Sample.Domain.Category;
using Sample.Domain.Entities.Base;
using Sample.ValueObjects;
using System.Collections.Generic;

namespace Sample.Domain.Entities
{
    public class CategoryEntity : Entity<CategoryId>
    {
        public CategoryEntity(NameValueObject name)
        {
            Name = name;
            Products = new List<ProductEntity>();
        }

        public NameValueObject Name { get; private set; }

        public List<ProductEntity> Products { get; private set; }
    }
}
