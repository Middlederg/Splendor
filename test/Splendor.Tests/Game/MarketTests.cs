using System.Linq;
using Splendor.Domain;
using Xunit;
using FluentAssertions;
using System;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class MarketTests
    {
        private readonly Market simpleMarket;
        private readonly Market completeMarket;

        public MarketTests()
        {
            simpleMarket = new Market(2, 1);
            completeMarket = new Market(7, 5);
        }

        [Fact]
        public void Should_contain_gems()
        {
            foreach (var gem in Gems.GetAllGems())
            {
                simpleMarket.AvaliableOfType(gem).Should().Be(2);
                simpleMarket.CanBeTakenTwoOfType(gem).Should().BeFalse();

                completeMarket.AvaliableOfType(gem).Should().Be(7);
                completeMarket.CanBeTakenTwoOfType(gem).Should().BeTrue();
            }

            simpleMarket.AvaliableOfType(Gems.Gold).Should().Be(1);
            completeMarket.AvaliableOfType(Gems.Gold).Should().Be(5);

            simpleMarket.CanBeTakenTwoOfType(Gems.Gold).Should().BeFalse();
            completeMarket.CanBeTakenTwoOfType(Gems.Gold).Should().BeFalse();
        }

        [Fact]
        public void Should_leave_take_2_only_when_are_more_then_4()
        {
            new Market(Market.MinimunForTwoOfTheSame, 0).CanBeTakenTwoOfType(Gems.Onyx).Should().BeTrue();
            new Market(Market.MinimunForTwoOfTheSame - 1, 0).CanBeTakenTwoOfType(Gems.Onyx).Should().BeFalse();
        }

        [Fact]
        public void Should_take_avaliable_gems_in_simple_market()
        {
            simpleMarket.CanBeTaken(GemCollectionFactory.FourEmeralds.ToArray()).Should().BeFalse();
            simpleMarket.CanBeTaken(GemCollectionFactory.NoGems.ToArray()).Should().BeFalse();
            simpleMarket.CanBeTaken(GemCollectionFactory.OneOnyx.ToArray()).Should().BeFalse();
            simpleMarket.CanBeTaken(GemCollectionFactory.OneOnyxOneRubyAndOneDiamond.ToArray()).Should().BeTrue();
            simpleMarket.CanBeTaken(GemCollectionFactory.OneSapphireAndOneDiamond.ToArray()).Should().BeFalse();
            simpleMarket.CanBeTaken(GemCollectionFactory.TwoDiamondsOneSapphireAndThreeRubys.ToArray()).Should().BeFalse();
            simpleMarket.CanBeTaken(GemCollectionFactory.TwoSaphires.ToArray()).Should().BeFalse();
            simpleMarket.CanBeTaken(Gems.Gold, Gems.Onyx, Gems.Ruby).Should().BeFalse();
            simpleMarket.CanBeTaken(Gems.Gold, Gems.Gold).Should().BeFalse();
            simpleMarket.CanBeTaken(Gems.Onyx, Gems.Onyx).Should().BeFalse();
            simpleMarket.CanBeTaken(Gems.Onyx, Gems.Diamond, Gems.Emerald).Should().BeTrue();
        }

        [Fact]
        public void Should_take_avaliable_gems_in_complete_market()
        {
            completeMarket.CanBeTaken(GemCollectionFactory.FourEmeralds.ToArray()).Should().BeFalse();
            completeMarket.CanBeTaken(GemCollectionFactory.NoGems.ToArray()).Should().BeFalse();
            completeMarket.CanBeTaken(GemCollectionFactory.OneOnyx.ToArray()).Should().BeFalse();
            completeMarket.CanBeTaken(GemCollectionFactory.OneOnyxOneRubyAndOneDiamond.ToArray()).Should().BeTrue();
            completeMarket.CanBeTaken(GemCollectionFactory.OneSapphireAndOneDiamond.ToArray()).Should().BeFalse();
            completeMarket.CanBeTaken(GemCollectionFactory.TwoDiamondsOneSapphireAndThreeRubys.ToArray()).Should().BeFalse();
            completeMarket.CanBeTaken(GemCollectionFactory.TwoSaphires.ToArray()).Should().BeTrue();
            completeMarket.CanBeTaken(Gems.Gold, Gems.Gold).Should().BeFalse();
            completeMarket.CanBeTaken(Gems.Onyx, Gems.Onyx).Should().BeTrue();
            completeMarket.CanBeTaken(Gems.Onyx, Gems.Diamond, Gems.Emerald).Should().BeTrue();
        }

        [Fact]
        public void Should_let_take_and_add_gems_to_market()
        {
            completeMarket.TakeGems(Gems.Ruby, Gems.Ruby);
            CheckMarket(completeMarket, new int[] { 7, 5, 7, 7, 7}, 5);
            completeMarket.TakeGems(Gems.Ruby, Gems.Ruby);
            CheckMarket(completeMarket, new int[] { 7, 3, 7, 7, 7 }, 5);
            
            ShouldThrow(() => completeMarket.TakeGems(Gems.Gold));
            ShouldThrow(() => completeMarket.TakeGems(Gems.Ruby, Gems.Ruby));
            ShouldThrow(() => completeMarket.TakeGems(Gems.Emerald, Gems.Ruby));
            ShouldThrow(() => completeMarket.TakeGems(Gems.Emerald));

            completeMarket.TakeGems(Gems.Ruby, Gems.Diamond, Gems.Emerald);
            CheckMarket(completeMarket, new int[] { 6, 2, 7, 7, 6 }, 5);
            completeMarket.TakeGold();
            CheckMarket(completeMarket, new int[] { 6, 2, 7, 7, 6 }, 4);
            completeMarket.TakeGems(Gems.Ruby, Gems.Diamond, Gems.Sapphire);
            CheckMarket(completeMarket, new int[] { 5, 1, 7, 6, 6 }, 4);
            completeMarket.TakeGems(Gems.Diamond, Gems.Diamond);
            CheckMarket(completeMarket, new int[] { 3, 1, 7, 6, 6 }, 4);
            completeMarket.TakeGems(Gems.Ruby, Gems.Emerald, Gems.Sapphire);
            CheckMarket(completeMarket, new int[] { 3, 0, 7, 5, 5 }, 4);

            ShouldThrow(() => completeMarket.TakeGems(Gems.Ruby, Gems.Emerald, Gems.Sapphire));
            ShouldThrow(() => completeMarket.TakeGems(Gems.Diamond, Gems.Diamond));

            completeMarket.Add(Gems.Diamond, Gems.Ruby);

            completeMarket.TakeGems(Gems.Ruby, Gems.Emerald, Gems.Sapphire);
            completeMarket.TakeGems(Gems.Diamond, Gems.Diamond);
        }

        private void CheckMarket(Market market, int[] values, int gold)
        {
            foreach (var gem in Gems.GetAllGems())
            {
                market.AvaliableOfType(gem).Should().Be(values[gem.Id - 1]);
                market.AvaliableGold().Should().Be(gold);
            }
        }

        private void ShouldThrow(Action action)
        {
            action.Should().Throw<DomainException>();
        }
    }
}
