using System.Drawing;

namespace Splendor.Domain
{
    public class Emerald : Gem
    {
        public override int Id => 5;
        public override string Path => "emerald";
        public override Color Color => Color.Green;

        internal Emerald() { }
    }
}
