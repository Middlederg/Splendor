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
        public void Gems_should_be_instantiated()
        {
            var gems = Gems.GetAllGems().ToList();
            foreach (var gem in gems)
            {
                gem.ToString().Should().Be(gem.GetType().Name);
                gem.GetImage().Should().NotBeNull();
                gem.IsGold.Should().Be(gem.ToString().Equals("Gold"));
            }
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
