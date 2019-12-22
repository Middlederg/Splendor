using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class PurchaseService
    {
        private readonly int gold;
        private readonly Development development;
        private readonly Player player;

        public PurchaseService(Development development, Player player)
        {
            this.development = development;
            this.player = player;
            gold = player.TotalGems(Gems.Gold);
        }

        private int WouldSpend(Gem gem) => Math.Max(0, development.TotalGemsOfType(gem) - player.Bonus(gem));
        private int Missing(Gem gem) => Math.Max(0, WouldSpend(gem) - player.TotalGems(gem));

        public int Cost() => Gems.GetAllGems().Sum(x => WouldSpend(x));

        public bool IsFree() => Gems.GetAllGems().All(gema => player.Bonus(gema) >= WouldSpend(gema));

        public bool CanAfford() => Gems.GetAllGems().All(gema => player.TotalGems(gema) >= WouldSpend(gema));
        public bool CanAffordPayingGold() => RequiredGold() <= gold;
        private int RequiredGold() => Gems.GetAllGems().Sum(gem => Missing(gem));
        private string RequiredGoldText() => $"{Gems.Gold.ToString(RequiredGold())}";

        public override string ToString()
        {
            if (CanAffordPayingGold())
                return $"You can afford the development paying {RequiredGoldText()} gold and {WouldSpendTexts().JoinList()}";

            if (!CanAfford())
                return $"You can not afford the development. You need {AreMissingTexts().JoinList()}";
            
            if (IsFree())
                return "You can buy it for free";

            return $"You can afford the development paying {WouldSpendTexts().JoinList()}";
        }

        private IEnumerable<string> WouldSpendTexts()
        {
            foreach (var gem in Gems.GetAllGems())
            {
                int count = WouldSpend(gem);
                if (count > 0)
                   yield return $"{gem.ToString(count)}";
            }
        }

        private IEnumerable<string> AreMissingTexts()
        {
            foreach (var gem in Gems.GetAllGems())
            {
                int count = Missing(gem);
                if (count > 0)
                    yield return $"{gem.ToString(count)}";
            }
        }

        public void Purchase(Deck deck, Market market)
        {
            if (!CanAfford())
                throw new DomainException($"{player.ToString()} can not afford {development.ToString()}");

            foreach (var gem in Gems.GetAllGems())
            {
                foreach (int i in Enumerable.Range(0, WouldSpend(gem)))
                {
                    player.TakeGem(gem);
                    market.AddGem(gem);
                }
            }

            deck.TakeCard(development);
            player.AddCard(development);
        }
    }
}
