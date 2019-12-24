namespace Splendor.Domain
{
    public class ReserveDevelopment : Move
    {
        private readonly Development development;
        private readonly bool takeGold;

        public override MoveType Type => MoveType.ReserveDevelopment;

        public ReserveDevelopment(Development development, bool takeGold, Noble noble) : base(noble)
        {
            this.development = development;
            this.takeGold = takeGold;
        }

        protected override string Description => $"Reserves development ({development.ToString()}){TakesGoldText})";
        private string TakesGoldText => takeGold ? ", and takes a gold joker token" : "without taking gold";
    }
}
