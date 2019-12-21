using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System;

namespace Splendor.Domain
{
    public static class Nobles
    {
        public const int NoblesDefaultPrestige = 3;

        public static Noble IsabelOfCastille => new Noble(new NobleNamesList()[0], NoblesDefaultPrestige, "IsabelLaCatolica", Gems.Diamond.Get(4), Gems.Onyx.Get(4));
        public static Noble CharlesQuint => new Noble(new NobleNamesList()[1], NoblesDefaultPrestige, "CarlosV", Gems.Diamond.Get(3), Gems.Ruby.Get(3), Gems.Onyx.Get(3));
        public static Noble AnneOfBrittany => new Noble(new NobleNamesList()[2], NoblesDefaultPrestige, "AnaGB", Gems.Diamond.Get(3), Gems.Sapphire.Get(3), Gems.Emerald.Get(3));
        public static Noble FrancisOfFrance => new Noble(new NobleNamesList()[3], NoblesDefaultPrestige, "FranciscoFrancia", Gems.Ruby.Get(3), Gems.Onyx.Get(3), Gems.Emerald.Get(3));
        public static Noble CatherineOfMedicis => new Noble(new NobleNamesList()[4], NoblesDefaultPrestige, "CatalinaMedici", Gems.Ruby.Get(3), Gems.Sapphire.Get(3), Gems.Emerald.Get(3));
        public static Noble MaryStart => new Noble(new NobleNamesList()[5], NoblesDefaultPrestige, "MariaEstuardo", Gems.Ruby.Get(4), Gems.Emerald.Get(4));
        public static Noble Macchiavelli => new Noble(new NobleNamesList()[6], NoblesDefaultPrestige, "Machiavello", Gems.Diamond.Get(4), Gems.Sapphire.Get(4));
        public static Noble HenriVIII => new Noble(new NobleNamesList()[7], NoblesDefaultPrestige, "Henry8", Gems.Ruby.Get(4), Gems.Onyx.Get(4));
        public static Noble SolimanTheMagnificent => new Noble(new NobleNamesList()[8], NoblesDefaultPrestige, "SolimanElMagnifico", Gems.Sapphire.Get(4), Gems.Emerald.Get(4));
        public static Noble ElisabethOfAustria => new Noble(new NobleNamesList()[9], NoblesDefaultPrestige, "IsabelBaviera", Gems.Diamond.Get(3), Gems.Onyx.Get(3), Gems.Sapphire.Get(3));

        public static IEnumerable<Noble> GetNobles()
        {
            yield return IsabelOfCastille;
            yield return CharlesQuint;
            yield return AnneOfBrittany;
            yield return FrancisOfFrance;
            yield return CatherineOfMedicis;
            yield return MaryStart;
            yield return Macchiavelli;
            yield return HenriVIII;
            yield return SolimanTheMagnificent;
            yield return ElisabethOfAustria;
        }

        public static IEnumerable<Noble> GetNobles(int numero) => GetNobles().GetRandomItems(numero);
    }
}
