using System.Drawing;

namespace Splendor.Domain
{
    public class Red : ColorGroup
    {
        public static Color WaxFlower = Color.FromArgb(241, 169, 160);
        public static Color Pomegranate = Color.FromArgb(240, 52, 52);

        public Red() : base(PlayingColor.Red, Pomegranate, WaxFlower) { }
    }
}
