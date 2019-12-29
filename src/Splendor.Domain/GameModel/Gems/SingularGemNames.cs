using System.Collections.Generic;

namespace Splendor.Domain
{
    public class SingularGemNames
    {
        private readonly Gem gem;

        public SingularGemNames(Gem gem)
        {
            this.gem = gem;
        }

        private readonly List<string[]> list = new List<string[]>()
        {
            new string[] { "diamond", "diamante" },
            new string[] { "ruby", "rubí" },
            new string[] { "onyx", "ónix" },
            new string[] { "sapphire", "zafiro" },
            new string[] { "emerald", "esmeralda" },
            new string[] { "gold joker token", "pieza de oro" },
        };

        public override string ToString() => list[gem.Id - 1][(int)Constants.CurrentLanguage];
    }
}
