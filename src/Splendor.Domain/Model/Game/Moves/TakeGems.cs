using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class TakeGems : GameAction
    {
        public IEnumerable<Gem> Gems { get; }
        public override MoveType Type => MoveType.TakeGems;

        public TakeGems(IEnumerable<Gem> gems, Noble noble) : base(noble)
        {
            Gems = gems;
        }

        protected override string Description => $"Takes { Gems.JoinList()}";
    }
}
