using System;
using System.Linq;

namespace Splendor.Domain
{
    public abstract class GameAction
    {
        protected string receivedVisit;
        protected abstract string Description { get; }

        public abstract MoveType Type { get; }

        public GameAction(Noble noble)
        {
            if (receivedVisit != null)
            {
                receivedVisit = $" Noble received: {noble.ToStringDetailed()}";
            }
            else receivedVisit = "";
        }

        public override string ToString() => $"{Description}{receivedVisit}";
    }
}
