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

        public bool IsFree() => Gems.GetAllGems().All(gem => player.Bonus(gem) >= WouldSpend(gem));

        public bool CanAfford() => Gems.GetAllGems().All(gem => player.TotalGems(gem) >= WouldSpend(gem));
        public bool CanAffordPayingGold() => RequiredGold() <= gold;
        private int RequiredGold() => Gems.GetAllGems().Sum(gem => Missing(gem));
        private string RequiredGoldText() => $"{Gems.Gold.ToString(RequiredGold())}";

        public override string ToString()
        {
            if (CanAffordPayingGold())
                return $"You can afford the development paying {RequiredGoldText()} gold and {WouldSpendText()}";

            if (!CanAfford())
                return $"You can not afford the development. You need {AreMissingText()}";
            
            if (IsFree())
                return "You can buy it for free";

            return $"You can afford the development paying {WouldSpendText()}";
        }

        private string WouldSpendText()
        {
            return Gems.GetAllGems()
                .SelectMany(gem => gem.Get(WouldSpend(gem)))
                .JoinList();
        }

        private string AreMissingText()
        {
            return Gems.GetAllGems()
                 .SelectMany(gem => gem.Get(Missing(gem)))
                 .JoinList();
        }

        public void Purchase(Deck deck, Market market)
        {
            if (!CanAffordPayingGold())
                throw new DomainException($"{player.ToString()} can not afford {development.ToString()}");

            var goldSpended = Enumerable.Range(0, RequiredGold()).Select(x => Gems.Gold).ToArray();
            player.TakeGems(goldSpended);
            market.Add(goldSpended);

            var expenses = new List<Gem>();
            foreach (var gem in Gems.GetAllGems())
            {
                foreach (int i in Enumerable.Range(0, WouldSpend(gem)))
                {
                    expenses.Add(gem);
                    market.Add(gem);
                }
            }
            player.TakeGems(expenses.ToArray());
            deck.BuyCard(development);
            player.BuyCard(development);
        }

      
    }
}
