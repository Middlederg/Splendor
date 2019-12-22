using System.Linq;

namespace Splendor.Domain
{
    public abstract class Gem : IPath
    {
        public abstract int Id { get; }
        public bool IsGold => Equals(Gems.Gold);
        public abstract string Path { get; }

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
