using System.Linq;
using System.Collections.Generic;
using Splendor.Domain;
using Xunit;
using FluentAssertions;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class DevelopmentTests
    {
        private readonly List<Development> deck;
        private readonly Development TwoOnysAndTwoSapphires;
        private readonly Development FiveRubys;

        public DevelopmentTests()
        {
            deck = DevelopmentsFactory.GetDeck().ToList();
            TwoOnysAndTwoSapphires = deck.First(x => x.Id == 1);
            FiveRubys = deck.First(x => x.Id == 41);
        }

        [Fact]
        public void Development_should_have_correct_properties()
        {
            
            TwoOnysAndTwoSapphires.TotalGemsOfType(Gems.Diamond).Should().Be(0);
            TwoOnysAndTwoSapphires.TotalGemsOfType(Gems.Ruby).Should().Be(0);
            TwoOnysAndTwoSapphires.TotalGemsOfType(Gems.Onyx).Should().Be(2);
            TwoOnysAndTwoSapphires.TotalGemsOfType(Gems.Sapphire).Should().Be(2);
            TwoOnysAndTwoSapphires.TotalGemsOfType(Gems.Emerald).Should().Be(0);
            TwoOnysAndTwoSapphires.TotalGemsOfType(Gems.Gold).Should().Be(0);

            TwoOnysAndTwoSapphires.TotalGems().Should().Be(4);
            TwoOnysAndTwoSapphires.Bonus.Should().Be(Gems.Diamond);
            TwoOnysAndTwoSapphires.Level.Should().Be(Level.Level1);
            ((int)TwoOnysAndTwoSapphires.Prestige).Should().Be(0);
            TwoOnysAndTwoSapphires.ToStringWithPrice().Should().Contain("2 onyx");
            TwoOnysAndTwoSapphires.ToStringWithPrice().Should().Contain("2 sapphires");
        }

        [Fact(Skip = "This should be corrected")]
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

        [Fact]
        public void Development_should_be_of_same_kind()
        {
            var developments = new List<Development>()
            {
                TwoOnysAndTwoSapphires,
                FiveRubys
            };

            developments.AllSameBonus().Should().BeTrue();
            developments.JoinList().ToLower().Should().Be("2 developments (diamond)");
        }
    }
}
