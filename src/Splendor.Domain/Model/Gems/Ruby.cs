namespace Splendor.Domain
{
    public class Ruby : Gem
    {
        public override bool IsGold => false;
        public override string Path => "rubi";
        internal Ruby() { }
        public override string ToString() => "Ruby";
    }
}
