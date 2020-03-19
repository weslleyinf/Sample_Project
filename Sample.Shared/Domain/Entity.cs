
using Sample.Domain.ValueObjects.Base;

namespace Sample.Domain.Entities.Base
{
    public abstract class Entity<T> : IEntity where T : IValueObject 
    {
        public T Identity { get; private set; }
    }
}
