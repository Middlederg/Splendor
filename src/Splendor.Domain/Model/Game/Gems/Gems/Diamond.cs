using System.Drawing;

namespace Splendor.Domain
{
    public class Diamond : Gem
    {
        public override int Id => 1;
        public override string Path => "diamante";
        public override Color Color => Color.White;

        internal Diamond() { }
    }
}
