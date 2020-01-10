using System;
using System.Linq;

namespace Splendor.Domain
{
    public abstract class GameAction
    {
        protected string receivedVisit;
        protected abstract string Description { get; }

        public abstract MoveType Type { get; }
        public Noble Noble { get; }

        public GameAction(Noble noble)
        {
            Noble = noble;
            if (!(noble is null))
            {
                receivedVisit = $" and receives the visit of {noble.ToString()}";
            }
            else receivedVisit = "";
        }

        public override string ToString() => $"{Description}{receivedVisit}";
        public virtual Prestige PrestigeObtained => Noble?.Prestige ?? Prestige.Zero;
        public string PrestigeObtainedText => PrestigeObtained > 0 ? PrestigeObtained.ToString() : "";
    }
}
