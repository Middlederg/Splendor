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
            new string[] { "diamond token", "diamante" },
            new string[] { "ruby token", "rubí" },
            new string[] { "onyx token", "ónix" },
            new string[] { "sapphire token", "zafiro" },
            new string[] { "emerald token", "esmeralda" },
            new string[] { "gold joker token", "pieza de oro" },
        };

        public override string ToString() => list[gem.Id - 1][(int)Constants.CurrentLanguage];
    }
}
