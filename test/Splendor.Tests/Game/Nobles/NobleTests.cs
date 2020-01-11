using Splendor.Domain;
using Xunit;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
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

        [Fact]
        public void Same_noble_should_be_compared_correctly()
        {
            var machiavelli = Nobles.Macchiavelli;
            var machiavelli2 = Nobles.Macchiavelli;

            machiavelli.Should().Be(machiavelli);
            machiavelli.Should().Be(machiavelli2);
            machiavelli.Equals(machiavelli2).Should().BeTrue();
        }

        [Fact]
        public void Same_nobles_of_list_should_be_compared_correctly()
        {
            var nobles = Nobles.GetNobles();
            var isabel1 = nobles.ElementAt(0);
            var isabel2 = nobles.ElementAt(0);

            isabel1.Should().Be(isabel2);

            isabel1.Equals(isabel2).Should().BeTrue();
        }

        [Fact]
        public void Should_distinguish_nobles_in_a_list()
        {
            var nobles = Nobles.GetNobles();
            var isabel1 = nobles.ElementAt(0);
            var isabel2 = nobles.ElementAt(0);

            var list = new List<Noble>()
            {
                isabel1,
                isabel2
            };

            list.Distinct().Count().Should().Be(1);
        }
    }
}
