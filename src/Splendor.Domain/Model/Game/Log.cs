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

        public void TakeGems(int currentTurn, Player player, Noble noble, params Gem[] gems)
        {
            entries.Add(new LogEntry(currentTurn, new TakeGems(gems, noble), player));
        }

        public void BuyDevelopment(int currentTurn, Player player, Noble noble, Development development)
        {
            entries.Add(new LogEntry(currentTurn, new BuyDevelopment(development, noble), player));
        }

        public void ReserveDevelopment(int currentTurn, Player player, Noble noble, Development development, bool takeGold)
        {
            entries.Add(new LogEntry(currentTurn, new ReserveDevelopment(development, takeGold, noble), player));
        }

        public IEnumerable<string> GetLog() => entries.Select(x => x.ToString());     
    }
}
