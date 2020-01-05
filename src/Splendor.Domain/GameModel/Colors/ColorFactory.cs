using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Splendor.Domain
{
    public static class ColorFactory
    {
        public static ColorGroup GetColor(PlayingColor color) => Colors[(int)color];

        public static ColorGroup DefaultBlue => new ColorGroup(PlayingColor.DefaultBlue, Color.SlateBlue, Color.DeepSkyBlue);
        public static ColorGroup Red => new ColorGroup(PlayingColor.Red, Color.IndianRed, Color.LightCoral);
        public static ColorGroup Green => new ColorGroup(PlayingColor.Green, Color.DarkOliveGreen, Color.LawnGreen);
        public static ColorGroup Gray => new ColorGroup(PlayingColor.Gray, Color.DarkGray, Color.LightGray);
        public static ColorGroup Orange => new ColorGroup(PlayingColor.Orange, Color.DarkOrange, Color.OldLace);
        public static ColorGroup Brown => new ColorGroup(PlayingColor.Brown, Color.Sienna, Color.SandyBrown);

        public static List<ColorGroup> Colors => new List<ColorGroup>() { DefaultBlue, Red, Green, Gray, Orange, Brown };

        public static ColorGroup GetRandomColor(params ColorGroup[] except)
        {
            var list = Colors.ToList();
            list.RemoveAll(x => except.Contains(x));
            return list.GetRandomItem();
        }
    }
}
