using System.Drawing;

namespace Splendor.Domain
{
    public class Onyx : Gem
    {
        public override int Id => 3;
        public override string Path => "onyx";
        public override Color Color => Color.Black;

        internal Onyx() { }
    }
}
