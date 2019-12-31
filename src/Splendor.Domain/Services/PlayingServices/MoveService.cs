using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class MoveService
    {
        private readonly int currentTurn;
        private readonly Market market;
        private readonly Deck deck;
        private readonly NobilityBox nobilityBox;
        private readonly Player currentPlayer;
        private readonly Log log;

        private readonly GlobalElectionService globalElectionService;

        public MoveService(Game game)
        {
            currentTurn = game.GetCurrentTurnNumber;
            market = game.Market;
            deck = game.Deck;
            currentPlayer = game.CurrentPlayer;
            log = game.Log;
            nobilityBox = game.NobilityBox;
            globalElectionService = new GlobalElectionService(game);
        }

        public GameAction MakeMove()
        {
            var development = globalElectionService.Search();
            if (!(development is null))
            {
                new PurchaseService(development, currentPlayer).Purchase(deck, market);
                var noble = ChooseRandomNobleIfPossible();
                return log.BuyDevelopment(currentTurn, currentPlayer, noble, development);
            }

            if (currentPlayer.TotalGems() <= 5)
            {
                var gems = ThreeRandomGems()?.ToArray() ?? new Gem[0];
                if (market.CanBeTaken(gems))
                {
                    new TakeGemsService(currentPlayer, market, gems).Take();
                    var noble = ChooseRandomNobleIfPossible();
                    return log.TakeGems(currentTurn, currentPlayer, noble, gems);
                }
            }

            if (currentPlayer.TotalGems() <= 8)
            {
                var gems = TwoSameRandomGems()?.ToArray() ?? new Gem[0];
                if (market.CanBeTaken(gems))
                {
                    new TakeGemsService(currentPlayer, market, gems).Take();
                    var noble = ChooseRandomNobleIfPossible();
                    return log.TakeGems(currentTurn, currentPlayer, noble, gems);
                }
            }

            Development developmentToReserve = RandomDevelopment();
            var reserveService = new ReserveService(developmentToReserve, currentPlayer, market);
            if (reserveService.CanReserve())
            {
                bool takeGold = reserveService.WouldTakeGoldToken();
                reserveService.Reserve(deck);
                var noble = ChooseRandomNobleIfPossible();
                return log.ReserveDevelopment(currentTurn, currentPlayer, noble, developmentToReserve, takeGold);
            }

            return null;
        }

        private Noble ChooseRandomNobleIfPossible()
        {
            var nobilityService = new NobilityService(nobilityBox, currentPlayer);
            var nobles = nobilityService.CanReceiveVisitFrom();
            return nobles.GetRandomItem();
        }

        private IEnumerable<Gem> ThreeRandomGems() => Gems.GetAllGems()
            .Where(gem => market.AvaliableOfType(gem) > 0)
            .ToList()
            .RandomizeList()
            .Take(3);

        private IEnumerable<Gem> TwoSameRandomGems() => Gems.GetAllGems()
            .Where(gem => market.CanBeTakenTwoOfType(gem))
            .ToList()
            .RandomizeList()
            .FirstOrDefault()?
            .Get(2);

        private Development RandomDevelopment() => deck.VisibleDevelopments().GetRandomItem();
    }
}
