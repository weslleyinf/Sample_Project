using Microsoft.EntityFrameworkCore;
using Sample.Database.Category.Write;
using Sample.Database.Product.Write;
using Sample.Domain.Entities;

namespace Sample.Database.Context
{
    public class WriteContext : DbContext
    {
        public WriteContext(DbContextOptions<WriteContext> options)
            : base(options)
        { }

        public DbSet<ProductEntity> Products { get; private set; }

        public DbSet<CategoryEntity> Categories { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductWriteMap());
            modelBuilder.ApplyConfiguration(new CategoryWriteMap());
        }
    }
}
