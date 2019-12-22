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
            new string[] { "diamond tokens", "diamantes" },
            new string[] { "ruby tokens", "rubíes" },
            new string[] { "onyx tokens", "ónix" },
            new string[] { "sapphire tokens", "zafiros" },
            new string[] { "emerald tokens", "esmeraldas" },
            new string[] { "gold joker tokens", "piezas de oro" },
        };

        public override string ToString() => list[gem.Id - 1][(int)Constants.CurrentLenguage];
    }
}
