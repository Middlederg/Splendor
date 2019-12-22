using System.Collections.Generic;

namespace Splendor.Domain
{
    public class NobleNamesList
    {
        public string this[int i]
        {
            get
            {
                return list[i][(int)Constants.CurrentLanguage];
            }
        }

        private readonly List<string[]> list = new List<string[]>()
        {
            new string[] { "Isabel of Castille","Isabel La Catolica" },
            new string[] { "Charles Quint","Carlos V" },
            new string[] { "Anne of Brittany", "Ana de Gran Bretaña" },
            new string[] { "Francis I of France","Francisco I de Francia" },
            new string[] { "Catherine of Medicis","Catalina de Medici" },
            new string[] { "Mary Stuart", "María Estuardo" },
            new string[] { "Macchiavelli", "Nicolás de Machiavello" },
            new string[] { "Henri VIII", "Enrique VIII" },
            new string[] { "Soliman the Magnificent","Solimán El Magnífico" },
            new string[] { "Elisabeth of Austria", "Isabel de Baviera" }
        };
    }
}
