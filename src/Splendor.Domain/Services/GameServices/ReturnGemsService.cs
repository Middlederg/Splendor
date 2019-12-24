using System.Linq;

namespace Splendor.Domain
{
    public class ReturnGemsService
    {
        private readonly Player player;
        private readonly Market market;
        private readonly int gemsToReturn;
        private readonly Gem[] gems;

        public ReturnGemsService(Player player, Market market, int gemsToReturn, params Gem[] gems)
        {
            this.player = player;
            this.market = market;
            this.gemsToReturn = gemsToReturn;
            this.gems = gems;
        }

        public bool CanBeReturned()
        {
            if (gems.Count() != gemsToReturn)
                return false;

            foreach (var gem in gems.Distinct())
            {
                int count = gems.Count(x => x == gem);
                if (player.TotalGems(gem) < count)
                    return false;
            }
            return true;
        }

        public void Return()
        {
            player.TakeGems(gems);
            market.Add(gems);
        }

        public override string ToString()
        {
            if (gems.Count() != gemsToReturn)
                return $"You must return {gemsToReturn} gems to the market";

            return $"Return {gems.JoinList()} to the market";
        }
    }
}
