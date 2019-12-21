using Splendor.Domain;
using Xunit;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;

namespace Splendor.Tests
{
    public class NobleTests
    {
        [Fact]
        public void Noble_should_have_correct_requirements()
        {
            var machiavelli = Nobles.Macchiavelli;
            machiavelli.RequiredQuantity(Gems.Diamond).Should().Be(4);
            machiavelli.RequiredQuantity(Gems.Ruby).Should().Be(0);
            machiavelli.RequiredQuantity(Gems.Onyx).Should().Be(0);
            machiavelli.RequiredQuantity(Gems.Sapphire).Should().Be(4);
            machiavelli.RequiredQuantity(Gems.Emerald).Should().Be(0);
            machiavelli.RequiredQuantity(Gems.Gold).Should().Be(0);
        }

        [Fact]
        public void Noble_name_should_be_in_proper_lenguage()
        {
            var henry = Nobles.HenriVIII;
            henry.ToString().Should().Be("Henri VIII");

            Constants.CurrentLenguage = Lenguage.Spanish;
            henry = Nobles.HenriVIII;
            henry.ToString().Should().Be("Enrique VIII");
        }

        [Fact]
        public void Noble_requirements_should_be_compensated()
        {
            var nobles = Nobles.GetNobles();

            var list = new List<(Gem gem, int count)>();
            foreach (var gem in Gems.GetAllGems())
            {
                int count = 0;
                foreach (var noble in nobles)
                {
                    count += noble.RequiredQuantity(gem);
                }
                list.Add((gem, count));
            }

            list.Select(x => x.count).Distinct().Count().Should().Be(1);
        }
    }
}
