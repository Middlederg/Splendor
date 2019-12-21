namespace Splendor.Domain
{
    public class Diamond : Gem
    {
        public override bool IsGold => false;
        public override string Path => "diamante";
        internal Diamond() { }
        public override string ToString() => "Diamond";
    }
}
