using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class TakeGems : GameAction
    {
        private readonly IEnumerable<Gem> gems;
        public override MoveType Type => MoveType.TakeGems;

        public TakeGems(IEnumerable<Gem> gems, Noble noble) : base(noble)
        {
            this.gems = gems;
        }

        protected override string Description => $"Takes { gems.JoinList()}";
    }
}
