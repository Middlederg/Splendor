using System;
using System.Linq;

namespace Splendor.Domain
{
    public class TakeGemsService
    {
        private readonly Player player;
        private readonly Market market;
        private readonly Gem[] gems;

        public TakeGemsService(Player player, Market market, params Gem[] gems)
        {
            this.player = player;
            this.market = market;
            this.gems = gems;
        }

        public bool CanBeTaken() => market.CanBeTaken(gems);
        public void Take()
        {
            market.TakeGems(gems);
            player.AddGems(gems);
        }

        public bool ShouldReturnGemsToMarket() => player.TotalGems() + gems.Count() > Player.MaxGems;
        public int GemsToReturnToMarket() => Math.Max(0, player.TotalGems() + gems.Count() - Player.MaxGems);

        public override string ToString()
        {
            if (!CanBeTaken())
                return $"You can not take {gems.JoinList()}";

            string returnGems = ShouldReturnGemsToMarket() ? $". You would have to return {GemsToReturnToMarket()} gems then" : "";
            return $"Take {gems.JoinList()}{returnGems}";
        }
    }
}
