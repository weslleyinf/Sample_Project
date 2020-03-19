
using Sample.Domain.Entities.Base;
using Sample.Kernel.Repository;

namespace Sample.Database.Category.Write
{
    public interface ICategoryWriteRepository<T>: IWriteRepository<T> where T : IEntity
    {
    }
}
