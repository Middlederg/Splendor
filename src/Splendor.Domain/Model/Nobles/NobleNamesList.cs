using System.Collections.Generic;

namespace Splendor.Domain
{
    public class NobleNamesList
    {
        public string this[int i]
        {
            get
            {
                if (Constants.CurrentLenguage == Lenguage.Spanish)
                    return spanishNames[i];
                return englishNames[i];
            }
        }

        private readonly List<string> englishNames = new List<string>()
        {
            "Isabel of Castille",
            "Charles Quint",
            "Anne of Brittany",
            "Francis I of France",
            "Catherine of Medicis",
            "Mary Stuart",
            "Macchiavelli",
            "Henri VIII",
            "Soliman the Magnificent",
            "Elisabeth of Austria"
        };

        private readonly List<string> spanishNames = new List<string>()
        {
            "Isabel La Catolica",
            "Carlos V",
            "Ana de Gran Bretaña",
            "Francisco I de Francia",
            "Catalina de Medici",
            "María Estuardo",
            "Nicolás de Machiavello",
            "Enrique VIII",
            "Solimán El Magnífico",
            "Isabel de Baviera"
        };
    }
}
