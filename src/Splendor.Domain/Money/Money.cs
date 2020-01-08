using System;

namespace Splendor.Domain
{
    public class Money
    {
        private readonly decimal amount;
        private readonly Currency currency;

        public Money(decimal amount, Currency currency)
        {
            if (currency is null)
                throw new ArgumentNullException(nameof(currency));

            this.amount = amount;
            this.currency = currency;
        }

        public static Money From(decimal amount, string code) => new Money(amount, Currency.FromCode(code));

        public override string ToString() => $"{amount} {currency.ToString()}";
    }
}
