namespace Splendor.Domain
{
    public class BuyDevelopment : Move
    {
        private readonly Development development;
        public override MoveType Type => MoveType.BuyDevelopment;

        public BuyDevelopment(Development development, Noble noble) : base(noble)
        {
            this.development = development;
        }

        protected override string Description => $"Buys development ({development.ToString()})";
    }
}
