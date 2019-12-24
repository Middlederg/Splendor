using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class ElectionService
    {
        private readonly Deck deck;
        private readonly Player currentPlayer;
        private readonly Prestige objetive;

        public ElectionService(Player currentPlayer, Deck deck, Prestige objetive)
        {
            this.currentPlayer = currentPlayer;
            this.deck = deck;
            this.objetive = objetive;
        }

        private IEnumerable<Development> Purchasables => deck.VisibleDevelopments()
            .Where(development => new PurchaseService(development, currentPlayer)
            .CanAfford());

        private IEnumerable<Development> PurchasablesPayingGold => deck.VisibleDevelopments()
            .Where(development => new PurchaseService(development, currentPlayer)
            .CanAffordPayingGold());

        public Development Victory()
        {
            if (PurchasablesPayingGold.Any(develepment => develepment.Prestige + currentPlayer.Prestige >= objetive))
                return PurchasablesPayingGold.OrderByDescending(x => x.Prestige).First();
            return null;
        }

        public Development Cheapest()
        {
            return Purchasables.OrderBy(develepment =>
                new PurchaseService(develepment, currentPlayer)
                .Cost())
                .FirstOrDefault();
        }

        public Development Free()
        {
            return Purchasables.Where(develepment =>
                new PurchaseService(develepment, currentPlayer)
                .IsFree())
                .OrderByDescending(development => development.Prestige)
                .FirstOrDefault();
        }

      
    }
}
