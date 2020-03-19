using Sample.Domain.Entities.Base;
using Sample.Domain.Product;

namespace Sample.Domain.Entities
{
    public class ProductEntity : Entity<ProductId>
    {
        public ProductEntity(ProductDescription description, ProductPrice price)
        {
            Description = description;
            Price = price;
        }

        public ProductDescription Description { get; private set; }

        public ProductPrice Price { get; private set; }

        public int CategoryId { get; private set; }

        public CategoryEntity Category { get; private set; }
    }
}
