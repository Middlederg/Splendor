namespace Splendor.Domain
{
    public class Onyx : Gem
    {
        public override bool IsGold => false;
        public override string Path => "onix";
        internal Onyx() { }
        public override string ToString() => "Onyx";
    }
}
