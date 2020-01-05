using System.Drawing;

namespace Splendor.Domain
{
    public class Yellow : ColorGroup
    {
        public static Color Dolly = Color.FromArgb(255, 255, 126);
        public static Color California = Color.FromArgb(248, 148, 6);

        public Yellow() : base(PlayingColor.Yellow, California, Dolly) { }
    }
}
