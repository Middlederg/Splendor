using System.Linq;

namespace Splendor.Domain
{
    public class ReserveService
    {
        public const int MaxReservesAllowed = 3;

        private readonly Development development;
        private readonly Player player;
        private readonly Market market;

        public ReserveService(Development development, Player player, Market market)
        {
            this.development = development;
            this.player = player;
            this.market = market;
        }

        public bool CanReserve()
        {
            return player.Developments.Count() < 3;
        }

        public bool WouldTakeGoldToken() => market.AvaliableGold() > 0;

        public override string ToString()
        {
            if (!CanReserve())
                return $"You can not reserve the development. You have already reserved {MaxReservesAllowed}";

            string goldText = WouldTakeGoldToken() ? ", and you would take a gold token" : ", but you would not take any gold token";
            return $"You can reserve {development.ToString()}{goldText}";
        }

        public void Reserve(Deck deck)
        {
            if (!CanReserve())
                throw new DomainException($"{player.ToString()} can not reserve {development.ToString()}");

            deck.ReserveCard(development);
            player.ReserveCard(development);

            if (WouldTakeGoldToken())
            {
                market.TakeGems(Gems.Gold);
                player.AddGem(Gems.Gold);
            }
        }
    }
}
