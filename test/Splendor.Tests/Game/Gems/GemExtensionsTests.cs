using Splendor.Domain;
using Xunit;
using FluentAssertions;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class GemExtensionsTests
    {
        [Fact]
        public void Should_get_a_gem_collection()
        {
            var generatedCollection = Gems.Emerald.Get(4);
            generatedCollection.Should().BeEquivalentTo(GemCollectionFactory.FourEmeralds);
        }

        [Fact]
        public void Should_get_one_gem()
        {
            var generatedCollection = Gems.Onyx.Get(1);
            generatedCollection.Should().BeEquivalentTo(GemCollectionFactory.OneOnyx);
        }

        [Fact]
        public void Should_get_an_empty_collection()
        {
            var generatedCollection = Gems.Onyx.Get(0);
            generatedCollection.Should().BeEmpty();
        }

        [Fact]
        public void Should_guess_if_all_Gems_are_the_same_kind_of_gem()
        {
            GemCollectionFactory.FourEmeralds.AllSame().Should().BeTrue();
            GemCollectionFactory.TwoDiamondsOneSapphireAndThreeRubys.AllSame().Should().BeFalse();
            GemCollectionFactory.OneOnyx.AllSame().Should().BeTrue();
            GemCollectionFactory.TwoSaphires.AllSame().Should().BeTrue();
            GemCollectionFactory.NoGems.AllSame().Should().BeFalse();
            GemCollectionFactory.OneSapphireAndOneDiamond.AllSame().Should().BeFalse();
            GemCollectionFactory.OneOnyxOneRubyAndOneDiamond.AllSame().Should().BeFalse();
        }

        [Fact]
        public void Should_guess_if_all_Gems_are_all_different_kind_of_gem()
        {
            GemCollectionFactory.FourEmeralds.AllDifferent().Should().BeFalse();
            GemCollectionFactory.TwoDiamondsOneSapphireAndThreeRubys.AllDifferent().Should().BeFalse();
            GemCollectionFactory.OneOnyx.AllDifferent().Should().BeTrue();
            GemCollectionFactory.TwoSaphires.AllDifferent().Should().BeFalse();
            GemCollectionFactory.NoGems.AllDifferent().Should().BeFalse();
            GemCollectionFactory.OneSapphireAndOneDiamond.AllDifferent().Should().BeTrue();
            GemCollectionFactory.OneOnyxOneRubyAndOneDiamond.AllDifferent().Should().BeTrue();
        }

        [Fact]
        public void Should_get_string_of_a_lis_of_gems()
        {
            GemCollectionFactory.FourEmeralds.JoinList().Should().Be("4 emeralds");
            GemCollectionFactory.TwoDiamondsOneSapphireAndThreeRubys.JoinList().Should().Be("2 diamonds, 1 sapphire, 3 rubys");
            GemCollectionFactory.OneOnyx.JoinList().Should().Be("1 onyx");
            GemCollectionFactory.TwoSaphires.JoinList().Should().Be("2 sapphires");
            GemCollectionFactory.NoGems.JoinList().Should().Be("");
            GemCollectionFactory.OneSapphireAndOneDiamond.JoinList().Should().Be("1 sapphire, 1 diamond");
            GemCollectionFactory.OneOnyxOneRubyAndOneDiamond.JoinList().Should().Be("1 onyx, 1 ruby, 1 diamond");
        }
    }
}
