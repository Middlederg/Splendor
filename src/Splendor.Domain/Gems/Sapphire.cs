namespace Splendor.Domain
{
    public class Sapphire : Gem
    {
        public override bool IsGold => false;
        public override string Path => "zafiro";
        internal Sapphire() { }
        public override string ToString() => "Sapphire";
    }
}
