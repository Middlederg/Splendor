using System.Collections.Generic;

namespace Splendor.Domain
{
    public static class Gems
    {
        public static Gem Diamond => new Diamond();
        public static Gem Ruby => new Ruby(); 
        public static Gem Onyx => new Onyx();
        public static Gem Sapphire => new Sapphire();
        public static Gem Emerald => new Emerald();
        public static Gem Gold => new Gold();

        public static IEnumerable<Gem> GetAllGems(bool includeGold = true)
        {
            yield return Diamond;
            yield return Ruby;
            yield return Onyx;
            yield return Sapphire;
            yield return Emerald;

            if (includeGold)
                yield return Gold;
        }

        public static (int oro, int gemas) GetNumGemasInicio(int numJugadores)
        {
            switch (numJugadores)
            {
                case 4:
                    return (5, 7);
                case 3:
                    return (5, 5);
            }
            return (5, 4);
        }
    }
}
