
using Microsoft.EntityFrameworkCore;
using Sample.Database.Context;
using Sample.Domain.Entities;
using Sample.Kernel.Repository;

namespace Sample.Database.Product.Write
{
    public class ProductWriteRepository : WriteRepository<ProductEntity>, IProductWriteRepository<ProductEntity>
    {
        public ProductWriteRepository(WriteContext context) : base(context) { }
    }
}
