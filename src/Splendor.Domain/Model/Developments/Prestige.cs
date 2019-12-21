using System;

namespace Splendor.Domain
{
    public class Prestige
    {
        public static Prestige FromScalar(int value) => new Prestige(value);

        private readonly int value;

        private Prestige(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Prestige), "Prestige should be a value grater than 0");
            this.value = value;
        }

        public static implicit operator int(Prestige prestige) => prestige.value;
        public static explicit operator Prestige(int value) => new Prestige(value);

        public override string ToString() => $"{value} pt{(value.IsPlural() ? "s" : "")}";

        public static bool operator ==(Prestige obj1, Prestige obj2) => obj1.Equals(obj2);
        public static bool operator !=(Prestige obj1, Prestige obj2) => !obj1.Equals(obj2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var prestige = (Prestige)obj;
            return prestige == value;
        }

        public override int GetHashCode() => value.GetHashCode();
    }
}
