using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class Game
    {
        private readonly Turn turn;
        
        public Deck Deck { get; }
        public NobilityBox NobilityBox { get; }
        public Market Market { get; }
        public Log Log { get; }

        public List<Player> Players { get; }
        public int PlayerCount => Players.Count();
        public Player HumanPlayerWithTurn => CurrentPlayer.IsHuman ? CurrentPlayer : null;
        public Player CurrentPlayer => Players[turn.CurrentPlayer];
        public IEnumerable<Player> OtherPlayers(Player player) => Players.Where(x => x != player);

        public Prestige Objetive { get; }

        public Game(Prestige objetive, params (Avatar avatar, ColorGroup color)[] profiles)
        {
            Players = profiles.CreatePlayers().ToList();
            Objetive = objetive;

            turn = new Turn(PlayerCount);
            NobilityBox = new NobilityBox(PlayerCount);
            Deck = new Deck();

            var (gold, gems) = Gems.GetNumGemasInicio(PlayerCount);
            Market = new Market(gems, gold);

            Log = new Log();
        }

        public Game ResetGame() => new Game(Objetive, Players.Select(x => (x.Avatar, x.Color)).ToArray());

        

        public bool IsGameEnd() => Players
            .Any(x => x.Prestige >= Objetive
            && turn.SameTurnsForAllPlayers);

        public int GetCurrentTurnNumber => turn.TurnNumber;
        public void NextTurn() => turn.NextTurn();

        public IEnumerable<GameResult> Ranking()
        {
            int i = 1;
            return Players
                .OrderByDescending(x => x.Prestige)
                .ThenBy(y => y.Developments.Count())
                .Select(x => new GameResult(i++, x.ToString(), x.Prestige, x.TotalDevelopments));
        }
    }
}
