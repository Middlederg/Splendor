using System;
using System.Drawing;

namespace Splendor.Domain
{
    public static class ColorExtensions
    {
        public static Color Darken(this Color color, byte count = 10)
        {
            var red = Math.Max(color.R - count, 0);
            var green = Math.Max(color.G - count, 0);
            var blue = Math.Max(color.B - count, 0);
            return Color.FromArgb(red, green, blue);
        }

        public static Color Lighten(this Color color, byte count = 10)
        {
            var red = Math.Max(color.R + count, 255);
            var green = Math.Max(color.G + count, 255);
            var blue = Math.Max(color.B + count, 255);
            return Color.FromArgb(red, green, blue);
        }
    }


}
