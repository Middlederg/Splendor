using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class Market
    {
        public const int MinimunForTwoOfTheSame = 4;

        private Action updateMarket;
        public void Subscribe(Action action) => updateMarket += action;

        private readonly List<Gem> gems;
        public void Add(params Gem[] gemsToAdd)
        {
            foreach (var gem in gemsToAdd)
            {
                gems.Add(gem);
            }
            updateMarket?.Invoke();
        }
        public void TakeGems(params Gem[] gemsToTake)
        {
            if (!CanBeTaken(gemsToTake))
                throw new DomainException($"Can not take {gemsToTake.JoinList()}");

            foreach (var gem in gemsToTake)
            {
                gems.Remove(gem);
            }
            updateMarket?.Invoke();
        }
        public int AvaliableOfType(Gem gem) => gems.Count(x => x == gem);

        public int AvaliableGold() => gems.Count(x => x == Gems.Gold);
        public void TakeGold()
        {
            if (AvaliableGold() <= 0)
                throw new DomainException("There is no gold to take");

            gems.Remove(Gems.Gold);
            updateMarket?.Invoke();
        }

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

        public bool CanBeTakenTwoOfType(Gem gem)
        {
            if (gem == Gems.Gold)
                return false;

            return AvaliableOfType(gem) >= MinimunForTwoOfTheSame;
        }

        public bool CanBeTaken(params Gem[] gems)
        {
            if (gems.Contains(Gems.Gold))
                return false;

            foreach (var gem in gems)
            {
                if (AvaliableOfType(gem) == 0)
                    return false;
            }

            if (gems.AllSame() && gems.Count() == 2 && CanBeTakenTwoOfType(gems.First()))
                return true;

            if (gems.AllDifferent() && gems.Count() == 3)
                return true;

            return false;
        }
    }
}
