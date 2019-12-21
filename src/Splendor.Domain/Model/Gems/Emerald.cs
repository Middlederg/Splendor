namespace Splendor.Domain
{
    public class Emerald : Gem
    {
        public override bool IsGold => false;
        public override string Path => "esmeralda";
        internal Emerald() { }
        public override string ToString() => "Emerald";
    }
}
