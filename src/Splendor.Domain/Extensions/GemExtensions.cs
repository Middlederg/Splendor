using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Splendor.Domain
{
    public static class GemExtensions
    {
        public static string Plural(this Gem gem, int numero)
        {
            if (numero <= 0)
                return "";

            if (numero == 1 && (gem == Gems.Gold))
                return $"1 pieza de oro";

            if (numero == 1)
                return $"1 {gem.ToString()}";

            if (gem == Gems.Gold)
                return $"{numero} piezas de oro";

            if (gem == Gems.Onyx)
                return $"{numero} ónix";

            if (gem == Gems.Ruby)
                return $"{numero} rubíes";

            return $"{numero} {gem.ToString().ToLower()}s";
        }

        public static IEnumerable<Gem> Get(this Gem gem, int x)
        {
            if (x < 0)
                return new List<Gem>();

            return Enumerable.Range(0, x).Select(i => gem).ToList();
        }
    }


}
