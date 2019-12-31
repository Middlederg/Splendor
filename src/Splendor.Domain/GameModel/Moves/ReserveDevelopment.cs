namespace Splendor.Domain
{
    public class ReserveDevelopment : GameAction
    {
        public Development Development { get; }
        public bool TakeGold { get; }

        public override MoveType Type => MoveType.ReserveDevelopment;

        public ReserveDevelopment(Development development, bool takeGold, Noble noble) : base(noble)
        {
            Development = development;
            TakeGold = takeGold;
        }

        protected override string Description => $"Reserves development ({Development.ToString()}){TakesGoldText})";
        private string TakesGoldText => TakeGold ? ", and takes a gold joker token" : "without taking gold";
    }
}
