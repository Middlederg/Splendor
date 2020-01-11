using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class Log
    {
        public List<LogEntry> Entries { get; private set; }

        public Log()
        {
            Entries = new List<LogEntry>();
        }

        public GameAction TakeGems(int currentTurn, Player player, Noble noble, params Gem[] gems)
        {
            var move = new TakeGems(gems, noble);
            Entries.Add(new LogEntry(currentTurn, move, player));
            return move;
        }

        public GameAction BuyDevelopment(int currentTurn, Player player, Noble noble, Development development)
        {
            var move = new BuyDevelopment(development, noble);
            Entries.Add(new LogEntry(currentTurn, move, player));
            return move;
        }

        public GameAction ReserveDevelopment(int currentTurn, Player player, Noble noble, Development development, bool takeGold)
        {
            var move = new ReserveDevelopment(development, takeGold, noble);
            Entries.Add(new LogEntry(currentTurn, move, player));
            return move;
        }

        
        public IEnumerable<string> GetLog() => Entries.Select(x => x.ToString());     
    }
}
