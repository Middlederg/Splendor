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
        public void Gold_gem_should_be_gold()
        {
            Gems.Gold.IsGold.Should().BeTrue();
        }

        [Fact]
        public void A_gems_should_be_instantiated_and_have_values()
        {       
            var gems = Gems.GetAllGemsWithGold().ToList();
            foreach (var gem in gems)
            {
                gem.ToString().Should().Be(gem.GetType().Name);
                gem.GetImage().Should().NotBeNull();
                gem.IsGold.Should().Be(gem.ToString().Equals("Gold"));
            }
        }

        [Fact]
        public void Check_plural_names()
        {
            Gems.Diamond.ToString(3).Should().Be("3 diamonds");
            Gems.Ruby.ToString(1).Should().Be("1 ruby");
            Gems.Onyx.ToString(4).Should().Be("4 onyx");
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
