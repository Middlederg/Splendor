using Xunit;
using Splendor.Domain;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

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

            foreach (var gem in Gems.GetAllGems())
            {
                Take(gem.Get(2).ToArray());
            }
            //Take(new Gem[3] { Gems.Diamond, Gems.Ruby, Gems.Onyx });
            //Take(new Gem[3] { Gems.Diamond, Gems.Ruby, Gems.Onyx });
        }

        private void Take(Gem[] gems)
        {
            var service = new TakeGemsService(game, game.Market, gems);
            service.Take();
        }

        [Theory()]
        [ClassData(typeof(TakeableGemsData))]
        public void ShouldBeAbleToTakeGems(Gem[] gems)
        {
            var service = new TakeGemsService(game.CurrentPlayer,
                game.Market, gems);
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

        public void ShouldNotAddGems()
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

    public class TakeableGemsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Gem[] { Gems.Onyx, Gems.Ruby, Gems.Sapphire } };
            yield return new object[] { -4, -6, -10 };
            yield return new object[] { -2, 2, 0 };
            yield return new object[] { int.MinValue, -1, int.MaxValue };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
