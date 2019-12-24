using Splendor.Domain;
using System;

namespace Splendor.Tests
{
    public class DefaultFixture : IDisposable
    {
        public DefaultFixture()
        {
            Constants.CurrentLanguage = Language.English;
        }

        public void Dispose()
        {
            Constants.CurrentLanguage = Language.English;
        }
    }
}
