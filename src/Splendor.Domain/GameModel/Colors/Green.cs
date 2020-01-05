using System.Drawing;

namespace Splendor.Domain
{
    public class Green : ColorGroup
    {
        public static Color BrightTourquise = Color.FromArgb(41, 241, 195);
        public static Color Salem = Color.FromArgb(30, 130, 76);

        public Green() : base(PlayingColor.Green, Salem, BrightTourquise) { }
    }
}
