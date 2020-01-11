using Xunit;
using Splendor.Domain;
using FluentAssertions;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class GemsServiceTests
    {
        private readonly Game game;
        public GemsServiceTests()
        {
            game = new Game(Prestige.FromScalar(15),
                (Avatars.Danilo, ColorFactory.DefaultBlue),
                (Avatars.Debra, ColorFactory.Gray));
        }

        public void ShouldAddGems()
        {
            var service = new TakeGemsService(game.CurrentPlayer,
                game.Market, Gems.Onyx, Gems.Sapphire);
            service.CanBeTaken().Should().BeTrue();
            service.ShouldReturnGemsToMarket().Should().BeFalse();
            service.GemsToReturnToMarket().Should().Be(0);
            service.Take();
            game.CurrentPlayer.Gems.Should().ContainEquivalentOf(Gems.Onyx);
            game.CurrentPlayer.Gems.Should().ContainEquivalentOf(Gems.Sapphire);
            game.CurrentPlayer.Gems.Count.Should().Be(2);
            game.Market.AvaliableOfType(Gems.Onyx).Should().Be(3);
            game.Market.AvaliableOfType(Gems.Sapphire).Should().Be(3);
        }
    }
}
