using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class Market
    {
        public const int MinimunForTwoOfTheSame = 4;

        private readonly List<Gem> gems;
        public void AddGems(params Gem[] gemsToAdd)
        {
            foreach (var gem in gemsToAdd)
            {
                gems.Add(gem);
            }
            updateMarket?.Invoke();
        }

        public void TakeGem(Gem gem)
        {
            var taken = gems.Remove(gem);
            if (!taken)
                throw new NotFoundException(nameof(Development));

            updateMarket?.Invoke();
        }

        private Action updateMarket;
        public void Subscribe(Action action) => updateMarket += action;

        public Market(int gemCount, int goldCount)
        {
            gems = new List<Gem>();
            foreach (var gem in Gems.GetAllGems())
            {
                foreach (var i in Enumerable.Range(0, gemCount))
                {
                    gems.Add(gem);
                }
            }

            foreach (var i in Enumerable.Range(0, goldCount))
            {
                gems.Add(Gems.Gold);
            }
        }

        public int AvaliableOfType(Gem gem) => gems.Count(x => x == gem);
        public int AvaliableGold() => gems.Count(x => x == Gems.Gold);
        public bool CanBeTakenTwoOfType(Gem gem) => gems.Count(x => x == gem) >= MinimunForTwoOfTheSame;
    }
}
