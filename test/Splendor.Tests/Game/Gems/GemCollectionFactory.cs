using Splendor.Domain;
using System.Collections.Generic;

namespace Splendor.Tests
{
    public static class GemCollectionFactory
    {
        public static readonly IEnumerable<Gem> FourEmeralds = new List<Gem> { Gems.Emerald, Gems.Emerald, Gems.Emerald, Gems.Emerald };
        public static IEnumerable<Gem> TwoDiamondsOneSapphireAndThreeRubys = new List<Gem> { Gems.Diamond, Gems.Diamond, Gems.Sapphire, Gems.Ruby, Gems.Ruby, Gems.Ruby };
        public static IEnumerable<Gem> OneOnyx = new List<Gem> { Gems.Onyx };
        public static IEnumerable<Gem> TwoSaphires = new List<Gem> { Gems.Sapphire, Gems.Sapphire };
        public static IEnumerable<Gem> NoGems = new List<Gem>();
        public static IEnumerable<Gem> OneSapphireAndOneDiamond = new List<Gem>() { Gems.Sapphire, Gems.Diamond };
        public static IEnumerable<Gem> OneOnyxOneRubyAndOneDiamond = new List<Gem>() { Gems.Onyx, Gems.Ruby, Gems.Diamond };
    }
}
