using Splendor.Domain;
using System;

namespace Splendor.Tests
{
    public class SpanishFixture : IDisposable
    {
        public SpanishFixture()
        {
            Constants.CurrentLanguage = Language.Spanish;
        }

        public void Dispose()
        {
            Constants.CurrentLanguage = Language.English;
        }
    }
}
