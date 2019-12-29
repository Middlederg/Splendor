using Splendor.Domain;
using System.Drawing;

namespace Splendor.Forms
{
    public static class GemColors
    {
        public static Color SoftBackColor(this Gem gema)
        {
            if (gema == Gems.Gold) return Color.FromArgb(255, 236, 139);
            if (gema == Gems.Diamond) return Color.FromArgb(210, 215, 211);
            if (gema == Gems.Ruby) return Color.FromArgb(241, 169, 160);
            if (gema == Gems.Onyx) return Color.FromArgb(171, 183, 183);
            if (gema == Gems.Sapphire) return Color.FromArgb(137, 196, 244);
            if (gema == Gems.Emerald) return Color.FromArgb(123, 239, 178);
            return Color.White;
        }

        public static Color StrongBackColor(this Gem gema)
        {
            if (gema == Gems.Gold) return Color.PaleGoldenrod;
            if (gema == Gems.Diamond) return Color.White;
            if (gema == Gems.Ruby) return Color.IndianRed;
            if (gema == Gems.Onyx) return Color.Black;
            if (gema == Gems.Sapphire) return Color.DarkViolet;
            if (gema == Gems.Emerald) return Color.ForestGreen;
            return Color.White;
        }
    }
}
