using System.Collections.Generic;

namespace Splendor.Domain
{
    public class SimulationService
    {
        private readonly Game game;

        public SimulationService(Game game)
        {
            this.game = game;
        }

        public void Play()
        {
            while (!game.IsGameEnd())
            {
                var moveService = new MoveService(game);
                moveService.MakeMove();
                game.NextTurn();
            }
        }

        public IEnumerable<GameResult> GameResults() => game.Ranking();
    }
}
