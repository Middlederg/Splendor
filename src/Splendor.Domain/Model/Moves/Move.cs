using System;
using System.Linq;

namespace Splendor.Domain
{
    public abstract class Move
    {
        protected string receivedVisit;
        protected abstract string Description { get; }

        public abstract MoveType Type { get; }

        public Move(Noble noble)
        {
            if (receivedVisit != null)
            {
                receivedVisit = $" Noble received: {noble.ToStringDetailed()}";
            }
            else receivedVisit = "";
        }

        public override string ToString() => $"{Type.DisplayName()}.{receivedVisit}";
        
    }
}
