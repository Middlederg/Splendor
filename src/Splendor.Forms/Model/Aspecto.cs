using Splendor.Domain;
using System.Drawing;
using System;

namespace Splendor.Forms.Model
{
    public static class Aspecto
    {
        public static Color Primary = Color.SlateBlue;
        public static Color Secondary = Color.DeepSkyBlue;
        public static Color Terciary = Color.BurlyWood;
        public static int IdSiluetaJugador = 1;
    }

    public static class AspectoGemas
    {
        public static Color ColorFondo(this Gem gema)
        {
            if (gema == Gems.Gold) return Color.FromArgb(255, 236, 139);
            if (gema == Gems.Diamond) return Color.FromArgb(210, 215, 211);
            if (gema == Gems.Ruby) return Color.FromArgb(241, 169, 160);
            if (gema == Gems.Onyx) return Color.FromArgb(171, 183, 183);
            if (gema == Gems.Sapphire) return Color.FromArgb(137, 196, 244);
            if (gema == Gems.Emerald) return Color.FromArgb(123, 239, 178);
            return Color.White;
        }
    }
}
