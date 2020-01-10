using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Splendor.Domain
{
    public static class ColorFactory
    {
        public static ColorGroup GetColor(PlayingColor color) => Colors[(int)color];

        public static ColorGroup DefaultBlue => new ColorGroup(PlayingColor.DefaultBlue, Color.SlateBlue, Color.DeepSkyBlue);
        public static ColorGroup Red => new Red();
        public static ColorGroup Green => new Green();
        public static ColorGroup Gray => new ColorGroup(PlayingColor.Gray, Color.DarkGray, Color.LightGray);
        public static ColorGroup Orange => new ColorGroup(PlayingColor.Orange, Color.DarkOrange, Color.OldLace);
        public static ColorGroup Purple => new Purple();
        public static ColorGroup Yellow => new Yellow();

        public static List<ColorGroup> Colors => new List<ColorGroup>() { DefaultBlue, Red, Green, Gray, Orange, Purple, Yellow };

        public static ColorGroup GetRandomColor(params ColorGroup[] except)
        {
            var list = Colors.Where(x => !except.Contains(x)).ToList();
            return list.GetRandomItem();
        }
    }
}
