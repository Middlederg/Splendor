using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class Log
    {
        private readonly List<LogEntry> entries;

        public Log()
        {
            entries = new List<LogEntry>();
        }

        public GameAction TakeGems(int currentTurn, Player player, Noble noble, params Gem[] gems)
        {
            var move = new TakeGems(gems, noble);
            entries.Add(new LogEntry(currentTurn, move, player));
            return move;
        }

        public GameAction BuyDevelopment(int currentTurn, Player player, Noble noble, Development development)
        {
            var move = new BuyDevelopment(development, noble);
            entries.Add(new LogEntry(currentTurn, move, player));
            return move;
        }

        public GameAction ReserveDevelopment(int currentTurn, Player player, Noble noble, Development development, bool takeGold)
        {
            var move = new ReserveDevelopment(development, takeGold, noble);
            entries.Add(new LogEntry(currentTurn, move, player));
            return move;
        }

        public IEnumerable<string> GetLog() => entries.Select(x => x.ToString());     
    }
}
