using System.Collections.Generic;

namespace Splendor.Domain
{
    public class GemNames
    {
        private readonly Gem gem;

        public GemNames(Gem gem)
        {
            this.gem = gem;
        }

        private readonly List<string[]> list = new List<string[]>()
        {
            new string[] { "Diamond", "Diamante" },
            new string[] { "Ruby", "Rubí" },
            new string[] { "Onyx", "Ónix" },
            new string[] { "Sapphire", "Zafiro" },
            new string[] { "Emerald", "Esmeralda" },
            new string[] { "Gold", "Oro" },
        };

        public override string ToString() => list[gem.Id - 1][(int)Constants.CurrentLanguage];
    }
}
