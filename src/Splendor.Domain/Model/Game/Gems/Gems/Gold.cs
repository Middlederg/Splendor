using System.Drawing;

namespace Splendor.Domain
{
    public class Gold : Gem
    {
        public override int Id => 6;
        public override string Path => "oro";
        public override Color Color => Color.PaleGoldenrod;

        internal Gold() { }
    }
}
