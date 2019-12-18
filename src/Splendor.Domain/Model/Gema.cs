using System.ComponentModel;

namespace Splendor.Core.Model
{
    public enum Gema
    {
        [Display(Name = "Oro")]
        Oro,

        [Display(Name = "Diamante")]
        Diamante,

        [Display(Name = "Rubí")]
        Rubi,

        [Display(Name = "Ónix")]
        Onix,

        [Display(Name = "Zafiro")]
        Zafiro,

        [Display(Name = "Esmeralda")]
        Esmeralda
    }

    public static class GemaHelper
    {
        public static string Plural(this Gema gema, int numero)
        {
            if (numero <= 0)
                return "";

            if (numero == 1 && (gema == Gema.Oro))
                return $"1 pieza de oro";

            if (numero == 1)
                return $"1 {gema.DisplayName()}";

            if (gema == Gema.Oro)
                return $"{numero} piezas de oro";

            if (gema == Gema.Onix)
                return $"{numero} ónix";

            if (gema == Gema.Rubi)
                return $"{numero} rubíes";

            return $"{numero} {gema.DisplayName().ToLower()}s";
        }
    }
}
