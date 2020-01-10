using FluentAssertions;
using Splendor.Domain;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Splendor.Tests
{
    public class MoveTests
    {
        private readonly Development fourPointDevelopment;

        public MoveTests()
        {
            fourPointDevelopment = DevelopmentsFactory.GetDeck().First(x => x.Id == 87);
        }

        [Fact]
        public void ShouldTakeGemsWithoutNoble()
        {
            var takeGems = new TakeGems(new List<Gem> { Gems.Onyx, Gems.Ruby }, null);
            takeGems.Gems.Should().Contain(Gems.Onyx);
            takeGems.Gems.Should().Contain(Gems.Ruby);
            takeGems.Noble.Should().BeNull();
            takeGems.Type.Should().Be(MoveType.TakeGems);
            takeGems.PrestigeObtained.Should().Be(Prestige.Zero);
            takeGems.PrestigeObtainedText.Should().Be("");
        }

        [Fact]
        public void ShouldTakeGemsandNoble()
        {
            var takeGems = new TakeGems(new List<Gem> { Gems.Onyx, Gems.Ruby }, Nobles.AnneOfBrittany);
            takeGems.Gems.Should().Contain(Gems.Onyx);
            takeGems.Gems.Should().Contain(Gems.Ruby);
            takeGems.Noble.Should().BeEquivalentTo(Nobles.AnneOfBrittany);
            takeGems.Type.Should().Be(MoveType.TakeGems);
            takeGems.PrestigeObtained.Should().Be(Prestige.FromScalar(3));
            takeGems.PrestigeObtainedText.Should().Be(Prestige.FromScalar(3).ToString());
        }

        [Fact]
        public void ShouldReserveDevelopment()
        {
            var reserve = new ReserveDevelopment(fourPointDevelopment, takeGold: false, null);
            reserve.Development.Should().BeEquivalentTo(fourPointDevelopment);
            reserve.TakeGold.Should().BeFalse();
            reserve.Noble.Should().BeNull();
            reserve.Type.Should().Be(MoveType.ReserveDevelopment);
            reserve.PrestigeObtained.Should().Be(Prestige.Zero);
            reserve.PrestigeObtainedText.Should().Be("");
        }

        [Fact]
        public void ShouldReserveDevelopmentAndNoble()
        {
            var reserve = new ReserveDevelopment(fourPointDevelopment, takeGold: true, Nobles.CharlesQuint);
            reserve.Development.Should().BeEquivalentTo(fourPointDevelopment);
            reserve.TakeGold.Should().BeTrue();
            reserve.Noble.Should().BeEquivalentTo(Nobles.CharlesQuint);
            reserve.Type.Should().Be(MoveType.ReserveDevelopment);
            reserve.PrestigeObtained.Should().Be(Prestige.FromScalar(3));
            reserve.PrestigeObtainedText.Should().Be(Prestige.FromScalar(3).ToString());
        }

        [Fact]
        public void ShouldBuyDevelopment()
        {
            var buy = new BuyDevelopment(fourPointDevelopment, null);
            buy.Development.Should().BeEquivalentTo(fourPointDevelopment);
            buy.Noble.Should().BeNull();
            buy.Type.Should().Be(MoveType.BuyDevelopment);
            buy.PrestigeObtained.Should().Be(Prestige.FromScalar(4));
            buy.PrestigeObtainedText.Should().Be(Prestige.FromScalar(4).ToString());
        }

        [Fact]
        public void ShouldBuyDevelopmentAndNoble()
        {
            var buy = new BuyDevelopment(fourPointDevelopment, Nobles.ElisabethOfAustria);
            buy.Development.Should().BeEquivalentTo(fourPointDevelopment);
            buy.Noble.Should().BeEquivalentTo(Nobles.ElisabethOfAustria);
            buy.Type.Should().Be(MoveType.BuyDevelopment);
            buy.PrestigeObtained.Should().Be(Prestige.FromScalar(7));
            buy.PrestigeObtainedText.Should().Be(Prestige.FromScalar(7).ToString());
        }
    }
}
