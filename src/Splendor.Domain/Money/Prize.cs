namespace Splendor.Domain
{
    public class Prize
    {
        private readonly string name;
        public Money Money { get; }

        public Prize(Money money, string name = null)
        {
            Money = money;
            this.name = name;
        }

        public override string ToString() => name ?? Money.ToString();
    }
}
