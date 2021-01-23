using System.Drawing;

namespace Splendor.Domain
{
    public class Sapphire : Gem
    {
        public override int Id => 4;
        public override string Path => "sapphire";
        public override Color Color => Color.DarkViolet;

        internal Sapphire() { }
    }
}
