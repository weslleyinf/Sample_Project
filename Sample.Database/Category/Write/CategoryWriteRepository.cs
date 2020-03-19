

using Sample.Database.Context;
using Sample.Domain.Entities;
using Sample.Kernel.Repository;

namespace Sample.Database.Category.Write
{
    public class CategoryWriteRepository : WriteRepository<CategoryEntity>, ICategoryWriteRepository<CategoryEntity>
    {
        public CategoryWriteRepository(WriteContext context) : base(context)
        {
        }
    }
}
