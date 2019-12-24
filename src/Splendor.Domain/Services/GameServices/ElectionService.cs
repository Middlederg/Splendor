using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class ElectionService
    {
        private readonly Player player;
        private readonly IEnumerable<Development> avaliableDevelopments;
        private readonly int objetive;

        public ElectionService(Player player, IEnumerable<Development> avaliableDevelopments, int objetive)
        {
            this.player = player;
            this.avaliableDevelopments = avaliableDevelopments;
            this.objetive = objetive;
        }

        private IEnumerable<Development> Purchasables => avaliableDevelopments
            .Where(development => new PurchaseService(development, player)
            .CanAfford());

        private IEnumerable<Development> PurchasablesPayingGold => avaliableDevelopments
            .Where(development => new PurchaseService(development, player)
            .CanAffordPayingGold());

        public Development Victory()
        {
            if (PurchasablesPayingGold.Any(develepment => develepment.Prestige + player.Prestige >= objetive))
                return PurchasablesPayingGold.OrderByDescending(x => x.Prestige).First();
            return null;
        }

        public Development Cheapest()
        {
            return Purchasables.OrderBy(develepment =>
                new PurchaseService(develepment, player)
                .Cost())
                .FirstOrDefault();
        }
    }
}
