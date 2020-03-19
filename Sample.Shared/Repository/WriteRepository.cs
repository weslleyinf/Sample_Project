using Microsoft.EntityFrameworkCore;
using Sample.Domain.Entities.Base;

namespace Sample.Kernel.Repository
{
    public class WriteRepository<T>: IWriteRepository<T> where T : class, IEntity 
    {
        private readonly DbSet<T> _set;

        public WriteRepository(DbContext _context)
        {
            _set = _context.Set<T>();
        }

        public void Insert(T entity)
        {
            _set.Add(entity);
        }

        public void Update(T entity)
        {
            _set.Update(entity).State = EntityState.Modified;
        }

        public void Delete(int entityId)
        {
            T entity = _set.Find(entityId);

            _set.Remove(entity);
        }
    }
}
