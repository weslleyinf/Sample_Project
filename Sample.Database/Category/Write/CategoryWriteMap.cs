using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain.Category;
using Sample.Domain.Entities;

namespace Sample.Database.Category.Write
{
    public class CategoryWriteMap : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.HasKey(e => e.Identity.Id);

            builder.OwnsOne(x => x.Name, y =>
            {
                y.Property(x => x.Name).IsRequired().HasColumnName(nameof(CategoryName.Name)).HasMaxLength(250);
            });

            builder.HasMany(x => x.Products).WithOne(x => x.Category);
        }
    }
}
