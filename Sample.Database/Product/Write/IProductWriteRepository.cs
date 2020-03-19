
using Microsoft.EntityFrameworkCore;
using Sample.Domain.Entities.Base;
using Sample.Kernel.Repository;

namespace Sample.Database.Product.Write
{
    public interface IProductWriteRepository<T>: IWriteRepository<T> where T : IEntity
    {
    }
}
