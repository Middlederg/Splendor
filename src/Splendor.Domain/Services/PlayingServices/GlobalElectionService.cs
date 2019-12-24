using System.Collections.Generic;

namespace Splendor.Domain
{
    public class GlobalElectionService
    {
        private readonly Deck deck;
        private readonly Player currentPlayer;
        private readonly IEnumerable<Player> otherPlayers;
        private readonly Prestige objetive;

        public GlobalElectionService(Game game)
        {
            deck = game.Deck;
            currentPlayer = game.CurrentPlayer;
            otherPlayers = game.OtherPlayers(currentPlayer);
            objetive = game.Objetive;
        }

        public Development Search()
        {
            Development result;
            var myElectionService = new ElectionService(currentPlayer, deck, objetive);
            result = myElectionService.Victory();
            if (result != null) 
                return result;

            foreach (var otherPlayer in otherPlayers)
            {
                result = new ElectionService(otherPlayer, deck, objetive).Victory();
                if (result != null)
                    return result;
            }

            result = myElectionService.Free();
            if (result != null)
                return result;

            result = myElectionService.Cheapest();
            if (result != null)
                return result;

            return null;
        }
    }
}
