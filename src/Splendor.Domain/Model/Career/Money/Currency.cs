using System;

namespace Splendor.Domain
{
    public class Currency
    {
        private readonly string code;

        public Currency(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentNullException(nameof(code));

            if (!Currencies.Instance.IsValid(code))
                throw new ArgumentException($"Invalid currency symbol ({code}).");

            this.code = code;
        }

        public static Currency FromCode(string code)
        {
            return new Currency(code);
        }

        public static implicit operator string(Currency currency)
        {
            return currency.code;
        }

        public static explicit operator Currency(string code)
        {
            return new Currency(code);
        }
    }
}
