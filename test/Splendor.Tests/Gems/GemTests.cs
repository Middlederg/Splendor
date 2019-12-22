using Splendor.Domain;
using System;
using System.Linq;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace Splendor.Tests
{
    public class GemTests
    {
        [Fact]
        public void Gems_gold_should_be_gold()
        {
            Gems.Gold.IsGold.Should().BeTrue();
        }

        [Fact]
        public void Gems_should_be_instantiated()
        {
            Constants.CurrentLenguage = Lenguage.English;
            var gems = Gems.GetAllGems().ToList();
            foreach (var gem in gems)
            {
                gem.ToString().Should().Be(gem.GetType().Name);
                gem.GetImage().Should().NotBeNull();
                gem.IsGold.Should().Be(gem.ToString().Equals("Gold"));
            }
        }

        [Fact]
        public void Check_spanish_names()
        {
            Constants.CurrentLenguage = Lenguage.Spanish;

            Gems.Diamond.ToString().Should().Be("Diamante");
            Gems.Ruby.ToString().Should().Be("Rub�");
            Gems.Onyx.ToString().Should().Be("�nix");
            Gems.Sapphire.ToString().Should().Be("Zafiro");
            Gems.Emerald.ToString().Should().Be("Esmeralda");
            Gems.Gold.ToString().Should().Be("Oro");
        }

        [Fact]
        public void Check_plural_names()
        {
            Constants.CurrentLenguage = Lenguage.English;

            Gems.Diamond.ToString(3).Should().Be("3 diamond tokens");
            Gems.Ruby.ToString(1).Should().Be("1 ruby token");
            Gems.Onyx.ToString(4).Should().Be("4 onyx tokens");
            Gems.Sapphire.ToString().Should().Be("Sapphire");
            Gems.Emerald.ToString().Should().Be("Emerald");
            Gems.Gold.ToString().Should().Be("Gold");
        }

        [Fact]
        public void Gems_should_be_well_compared_with_operators()
        {
            var gemsList = new List<Gem>() { Gems.Diamond, Gems.Ruby, Gems.Onyx, Gems.Sapphire, Gems.Emerald, Gems.Gold };
            var anotherGemList = new List<Gem>() { Gems.Diamond, Gems.Ruby, Gems.Onyx, Gems.Sapphire, Gems.Emerald, Gems.Gold };

            for (int i = 0; i < gemsList.Count; i++)
            {
                bool resultTrue = gemsList[i] == anotherGemList[i];
                resultTrue.Should().BeTrue();

                bool resultFalse = gemsList[i] != anotherGemList[i];
                resultFalse.Should().BeFalse();
            }
        }

        [Fact]
        public void Gems_should_be_well_compared_with_equals()
        {
            var gemsList = new List<Gem>() { Gems.Diamond, Gems.Ruby, Gems.Onyx, Gems.Sapphire, Gems.Emerald, Gems.Gold };
            var anotherGemList = new List<Gem>() { Gems.Diamond, Gems.Ruby, Gems.Onyx, Gems.Sapphire, Gems.Emerald, Gems.Gold };

            for (int i = 0; i < gemsList.Count; i++)
            {
                bool resultTrue = gemsList[i].Equals(anotherGemList[i]);
                resultTrue.Should().BeTrue();

                bool resultFalse = !gemsList[i].Equals(anotherGemList[i]);
                resultFalse.Should().BeFalse();
            }
        }
    }
}