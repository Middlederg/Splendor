using System.Drawing;

namespace Splendor.Domain
{
    public class Purple : ColorGroup
    {
        public static Color Snuff = Color.FromArgb(220, 198, 224);
        public static Color Wisteria = Color.FromArgb(155, 89, 182);

        public Purple() : base(PlayingColor.Purple, Wisteria, Snuff) { }
    }
}
