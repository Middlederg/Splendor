using System.Linq;

namespace Splendor.Domain
{
    public abstract class Gem : IPath
    {
        public abstract bool IsGold { get; }
        public abstract string Path { get; }

        public static bool operator ==(Gem gem1, Gem gem2) => gem1.Equals(gem2);
        public static bool operator !=(Gem gem1, Gem gem2) => !gem1.Equals(gem2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return obj.ToString().Equals(ToString());
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
