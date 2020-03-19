
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain.Entities;
using Sample.Domain.Product;

namespace Sample.Database.Product.Write
{
    public class ProductWriteMap : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(e => e.Identity.Id);

            builder.OwnsOne(x => x.Description, y =>
            {
                y.Property(x => x.Description).IsRequired().HasColumnName(nameof(ProductDescription.Description)).HasMaxLength(250);
            });

            builder.OwnsOne(x => x.Price, y =>
            {
                y.Property(x => x.Sign).IsRequired().HasColumnName(nameof(ProductPrice.Sign)).HasMaxLength(5);
                y.Property(x => x.Value).IsRequired().HasColumnName(nameof(ProductPrice.Value));
            });

            builder.HasOne(x => x.Category).WithMany(x => x.Products);
        }
    }
}