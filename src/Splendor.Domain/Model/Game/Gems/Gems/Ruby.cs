using System.Drawing;

namespace Splendor.Domain
{
    public class Ruby : Gem
    {
        public override int Id => 2;
        public override string Path => "ruby";
        public override Color Color => Color.IndianRed;

        internal Ruby() { }
    }
}
