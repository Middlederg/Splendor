using System.Drawing;
using System.Linq;

namespace Splendor.Domain
{
    public abstract class Gem : IPath
    {
        public abstract int Id { get; }
        public bool IsGold => Equals(Gems.Gold);
        public abstract Color Color { get; }
        public abstract string Path { get; }
        public IPath SmallPath => new NamedPath($"{Path.Substring(0, 1).ToString().ToUpper()}{Path.Substring(1)}Small");
        public IPath PilePath(int number)
        {
            switch (number)
            {
                case 0: return NamedPath.Empty;
                case 1: return new NamedPath($"{GetType().Name.ToLower()}1");
                case 2: return new NamedPath($"{GetType().Name.ToLower()}2");
                case 3: return new NamedPath($"{GetType().Name.ToLower()}3");
                case 4: return new NamedPath($"{GetType().Name.ToLower()}3");
                case 5: return new NamedPath($"{GetType().Name.ToLower()}4");
                case 6: return new NamedPath($"{GetType().Name.ToLower()}4");
                default: return new NamedPath($"{GetType().Name.ToLower()}5");
            }
        }

        public static bool operator ==(Gem gem1, Gem gem2) => gem1.Equals(gem2);
        public static bool operator !=(Gem gem1, Gem gem2) => !gem1.Equals(gem2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var gem = (Gem)obj;
            return gem.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
        public override string ToString() => new GemNames(this).ToString();
        private string SingularToString() => new SingularGemNames(this).ToString();
        private string PluralToString() => new PluralGemNames(this).ToString();
        public string ToString(int quantity) => $"{quantity} {(quantity == 1 ? SingularToString(): PluralToString())}";
    }
}
