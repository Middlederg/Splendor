using FluentAssertions;
using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class PlayerTests
    {
        private readonly Development Diamond1;
        private readonly Development Diamond2;
        private readonly Development Onyx1;
        private readonly Development Onyx2;
        private readonly Development Onyx3;
        private readonly Development Emerald;

        private readonly Player player;

        public PlayerTests()
        {
            var deck = DevelopmentsFactory.GetDeck();
            Diamond1 = deck.First(x => x.Id == 1);
            Diamond2 = deck.First(x => x.Id == 41);
            Onyx1 = deck.First(x => x.Id == 53);
            Onyx2 = deck.First(x => x.Id == 54);
            Onyx3 = deck.First(x => x.Id == 55);
            Emerald = deck.First(x => x.Id == 33);

            player = new Player(1, Avatars.Danilo, ColorFactory.DefaultBlue, isHuman: true);

            player.BuyCard(Diamond1);
            player.BuyCard(Diamond2);
            player.BuyCard(Onyx1);
            player.BuyCard(Onyx2);
            player.BuyCard(Onyx3);

            player.ReserveCard(Emerald);

            player.AddGems(Gems.Onyx, Gems.Sapphire, Gems.Sapphire);
        }

        [Fact]
        public void Should_check_developments()
        {
            player.TotalDevelopments.Should().Be(5);
            player.GetDevelopmentsOfType(Gems.Emerald).Should().BeEmpty();
            player.GetDevelopmentsOfType(Gems.Sapphire).Should().BeEmpty();
            player.GetDevelopmentsOfType(Gems.Ruby).Should().BeEmpty();
            player.GetDevelopmentsOfType(Gems.Diamond).Should().ContainEquivalentOf(Diamond1);
            player.GetDevelopmentsOfType(Gems.Diamond).Should().ContainEquivalentOf(Diamond2);
            player.GetDevelopmentsOfType(Gems.Onyx).Should().ContainEquivalentOf(Onyx1);
            player.GetDevelopmentsOfType(Gems.Onyx).Should().ContainEquivalentOf(Onyx2);
            player.GetDevelopmentsOfType(Gems.Onyx).Should().ContainEquivalentOf(Onyx3);

            player.Bonus(Gems.Diamond).Should().Be(2);
            player.Bonus(Gems.Ruby).Should().Be(0);
            player.Bonus(Gems.Onyx).Should().Be(3);
            player.Bonus(Gems.Sapphire).Should().Be(0);
            player.Bonus(Gems.Emerald).Should().Be(0);
        }

        [Fact]
        public void Should_check_gems()
        {
            player.TotalDevelopments.Should().Be(5);
            player.TotalGems().Should().Be(3);
            player.GemsOfType(Gems.Diamond).Should().BeEmpty();
            player.GemsOfType(Gems.Ruby).Should().BeEmpty();
            player.GemsOfType(Gems.Onyx).Should().ContainSingle();
            player.GemsOfType(Gems.Sapphire).Count().Should().Be(2);
            player.GemsOfType(Gems.Emerald).Should().BeEmpty();
            player.TotalGems(Gems.Diamond).Should().Be(0);
            player.TotalGems(Gems.Ruby).Should().Be(0);
            player.TotalGems(Gems.Onyx).Should().Be(1);
            player.TotalGems(Gems.Sapphire).Should().Be(2);
            player.TotalGems(Gems.Emerald).Should().Be(0);
        }

        [Fact]
        public void Should_check_prestige()
        {
            player.Prestige.Should().Be((Prestige)7);
            player.AddNoble(Nobles.AnneOfBrittany);
            player.Prestige.Should().Be((Prestige)10);
        }

        [Fact]
        public void Should_check_purchasing_power()
        {
            player.TotalDevelopments.Should().Be(5);
            player.PurchasingPower(Gems.Diamond).Should().Be(2);
            player.PurchasingPower(Gems.Ruby).Should().Be(0);
            player.PurchasingPower(Gems.Onyx).Should().Be(4);
            player.PurchasingPower(Gems.Sapphire).Should().Be(2);
            player.PurchasingPower(Gems.Emerald).Should().Be(0);
        }

        [Fact]
        public void Should_spend_gems()
        {
            player.TakeGems(Gems.Sapphire);
            player.PurchasingPower(Gems.Sapphire).Should().Be(1);
        }

        [Fact]
        public void Should_not_spend_gem_that_player_has_not()
        {
            Action action = () => player.TakeGems(Gems.Ruby);
            action.Should().Throw<NotFoundException>();
        }
    }
}
