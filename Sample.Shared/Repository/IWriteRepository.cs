using Sample.Domain.Entities.Base;

namespace Sample.Kernel.Repository
{
    public interface IWriteRepository<T> where T : IEntity
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(int entityId);
    }
}
