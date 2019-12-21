using System.Linq;
using System.Collections.Generic;
using Splendor.Domain;
using Xunit;
using FluentAssertions;

namespace Splendor.Tests
{
    public class DevelopmentTest
    {
        private readonly List<Development> deck;

        public DevelopmentTest()
        {
            deck = DevelopmentsFactory.GetDeck().ToList();
        }

        [Fact]
        public void Development_should_have_correct_requirements()
        {
            var item = deck.First(x => x.Id == 1);
            item.TotalGemsOfType(Gems.Diamond).Should().Be(0);
            item.TotalGemsOfType(Gems.Ruby).Should().Be(0);
            item.TotalGemsOfType(Gems.Onyx).Should().Be(2);
            item.TotalGemsOfType(Gems.Sapphire).Should().Be(2);
            item.TotalGemsOfType(Gems.Emerald).Should().Be(0);
            item.TotalGemsOfType(Gems.Gold).Should().Be(0);

            item.TotalGems().Should().Be(4);
        }

        [Fact]
        public void Development_requirements_should_be_compensated()
        {
            var list = new List<(Gem gem, int count)>();
            foreach (var gem in Gems.GetAllGems())
            {
                int count = 0;
                foreach (var item in deck)
                {
                    count += item.TotalGemsOfType(gem);
                }
                list.Add((gem, count));
            }

            list.Select(x => x.count).Distinct().Count().Should().Be(1);
        }
    }
}
