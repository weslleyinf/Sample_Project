
using Sample.Domain.ValueObjects.Base;
using Sample.Kernel.Utility;

namespace Sample.ValueObjects
{
    public abstract class DescriptionValueObject : ValueObject<DescriptionValueObject>
    {
        public string Description { get; }

        public DescriptionValueObject(string description)
        {
            Description = description;
        }

        protected override bool EqualsCore(DescriptionValueObject other) => Description.Equals(other.Description);

        protected override int GetHashCodeCore() => Description.GetHashCode();

        public override string ToString() => Description.FirstCapitalLetter();
    }
}
