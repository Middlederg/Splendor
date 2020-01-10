using System.Linq;
using Splendor.Domain;
using Xunit;
using FluentAssertions;
using System;

namespace Splendor.Tests
{

    public class DeckTests
    {
        private readonly Deck deck;

        public DeckTests()
        {
            deck = new Deck();
        }

        [Fact]
        public void Should_take_a_development()
        {
            var item = deck.VisibleDevelopments().First();

            deck.VisibleDevelopments().Should().Contain(item);
            deck.BuyCard(item);
            deck.VisibleDevelopments().Should().NotContain(item);
        }

        [Fact]
        public void Should_not_take_a_development_when_it_is_not_in_the_list()
        {
            var item = deck.VisibleDevelopments().First();
            deck.BuyCard(item);

            Action action = () => deck.BuyCard(item);
            action.Should().Throw<DomainException>();
        }

        [Fact]
        public void Should_remain_developments_when_taking_one()
        {
            var item = deck.VisibleDevelopments().First();

            deck.VisibleDevelopments().Count().Should().Be(Deck.VisibleDevelopmentsPerRow * 3);
            deck.BuyCard(item);
            deck.VisibleDevelopments().Count().Should().Be(Deck.VisibleDevelopmentsPerRow * 3);
        }
    }
}
