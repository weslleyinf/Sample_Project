
using Sample.Domain.ValueObjects.Base;

namespace Sample.ValueObjects
{
    public abstract class InternalIdValueObject : ValueObject<InternalIdValueObject>
    {
        public int Id { get; }

        public InternalIdValueObject(int id)
        {
            Id = id;
        }

        protected override bool EqualsCore(InternalIdValueObject other) => Id.Equals(other.Id);

        protected override int GetHashCodeCore() => Id.GetHashCode();
    }
}
