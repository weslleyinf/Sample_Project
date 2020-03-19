﻿
using Sample.Domain.ValueObjects.Base;
using Sample.Kernel.Utility;

namespace Sample.ValueObjects
{
    public abstract class NameValueObject: ValueObject<NameValueObject>
    {
        public string Name { get; }

        public NameValueObject(string name)
        {
            Name = name;
        }

        protected override bool EqualsCore(NameValueObject other) => Name.Equals(other.Name);

        protected override int GetHashCodeCore() => Name.GetHashCode();

        public override string ToString() => Name.FirstCapitalLetters();
    }
}
