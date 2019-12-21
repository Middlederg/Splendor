namespace Splendor.Domain
{
    public class Gold : Gem
    {
        public override bool IsGold => true;
        public override string Path => "oro";
        internal Gold() { }
        public override string ToString() => "Gold";
    }
}
