using Splendor.Domain;
using Xunit;
using FluentAssertions;

namespace Splendor.Tests
{
    [Collection(nameof(SpanishCollection))]
    public class GemSpanishTests
    {
        [Fact]
        public void Check_spanish_names()
        {
            Gems.Diamond.ToString().Should().Be("Diamante");
            Gems.Ruby.ToString().Should().Be("Rubí");
            Gems.Onyx.ToString().Should().Be("Ónix");
            Gems.Sapphire.ToString().Should().Be("Zafiro");
            Gems.Emerald.ToString().Should().Be("Esmeralda");
            Gems.Gold.ToString().Should().Be("Oro");
        }

        [Fact]
        public void Noble_name_should_be_in_proper_lenguage()
        {
            var henry = Nobles.HenriVIII;
            henry.ToString().Should().Be("Enrique VIII");
        }
    }
}
