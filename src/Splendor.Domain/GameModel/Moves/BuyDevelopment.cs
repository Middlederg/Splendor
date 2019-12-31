namespace Splendor.Domain
{
    public class BuyDevelopment : GameAction
    {
        public Development Development { get; }
        public override MoveType Type => MoveType.BuyDevelopment;

        public BuyDevelopment(Development development, Noble noble) : base(noble)
        {
            Development = development;
        }

        protected override string Description => $"Buys development ({Development.ToString()})";
    }
}
