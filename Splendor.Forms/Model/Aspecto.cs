using Splendor.Core.Model;
using System.Drawing;
using System;

namespace Splendor.Forms.Model
{
    public static class Aspecto
    {
        public static Color Primary = Color.Sienna;
        public static Color Secondary = Color.BlanchedAlmond;
        public static Color Terciary = Color.BurlyWood;
        public static int IdSiluetaJugador = 1;
    }

    public static class AspectoGemas
    {
        public static Color ColorFondo(this Gema gema)
        {
            switch (gema)
            {
                case Gema.Oro: return Color.FromArgb(255, 236, 139);
                case Gema.Diamante:  return Color.FromArgb(210, 215, 211);
                case Gema.Rubi: return Color.FromArgb(241, 169, 160);
                case Gema.Onix: return Color.FromArgb(171, 183, 183);
                case Gema.Zafiro: return Color.FromArgb(137, 196, 244);
                case Gema.Esmeralda: return Color.FromArgb(123, 239, 178);
            }
            return Color.White;
        }
    }
}
