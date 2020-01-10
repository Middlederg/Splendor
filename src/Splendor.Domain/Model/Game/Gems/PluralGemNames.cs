using System.Collections.Generic;

namespace Splendor.Domain
{
    public class PluralGemNames
    {
        private readonly Gem gem;

        public PluralGemNames(Gem gem)
        {
            this.gem = gem;
        }

        private readonly List<string[]> list = new List<string[]>()
        {
            new string[] { "diamonds", "diamantes" },
            new string[] { "rubys", "rubíes" },
            new string[] { "onyx", "ónix" },
            new string[] { "sapphires", "zafiros" },
            new string[] { "emeralds", "esmeraldas" },
            new string[] { "gold joker tokens", "piezas de oro" },
        };

        public override string ToString() => list[gem.Id - 1][(int)Constants.CurrentLanguage];
    }
}
