namespace Splendor.Domain
{
    public class CashPrize : IPrize
    {
        private readonly string name;
        public Money Money { get; }
        public int Value => (int)((decimal)Money);

        public CashPrize(Money money, string name = null)
        {
            Money = money;
            this.name = name;
        }

        public override string ToString() => name ?? Money.ToString();
    }
}
