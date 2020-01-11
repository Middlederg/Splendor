using System.Linq;
using Splendor.Domain;
using Xunit;
using FluentAssertions;
using System;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
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
        public void Should_reserve_a_development()
        {
            var item = deck.VisibleDevelopments().First();

            deck.VisibleDevelopments().Should().Contain(item);
            deck.ReserveCard(item);
            deck.VisibleDevelopments().Should().NotContain(item);
        }

        [Fact]
        public void Should_reserve_a_hidden_development()
        {
            var item = deck.HiddenDevelopment(Level.Level2);

            deck.VisibleDevelopments().Should().NotContain(item);
            deck.ReserveCard(item);
            deck.VisibleDevelopments().Should().NotContain(item);
        }

        [Fact]
        public void Should_not_buy_a_development_when_it_is_not_in_the_list()
        {
            var item = deck.VisibleDevelopments().First();
            deck.BuyCard(item);

            Action action = () => deck.BuyCard(item);
            action.Should().Throw<NotFoundException>();
        }

        [Fact]
        public void Should_not_buy_a_development_when_it_is_hidden()
        {
            var item = deck.VisibleDevelopments().First();
            deck.BuyCard(item);

            Action action = () => deck.BuyCard(item);
            action.Should().Throw<NotFoundException>();
        }

        [Fact]
        public void Should_remain_developments_when_taking_one()
        {
            var item = deck.VisibleDevelopments().First();

            deck.VisibleDevelopments().Count().Should().Be(Deck.VisibleDevelopmentsPerRow * 3);
            deck.BuyCard(item);
            deck.VisibleDevelopments().Count().Should().Be(Deck.VisibleDevelopmentsPerRow * 3);
        }

        [Fact]
        public void Should_remain_consistent_deck_after_taking_all_level_1_cards()
        {
            while (deck.RemainigDeckCards(Level.Level1) > 0)
            {
                var development = deck.VisibleDevelopments(Level.Level1).First();
                deck.BuyCard(development);
            }

            deck.VisibleDevelopments(Level.Level1).Count().Should().Be(Deck.VisibleDevelopmentsPerRow);
            deck.HiddenDevelopment(Level.Level1).Should().BeNull();
            deck.RemainigDeckCards(Level.Level1).Should().Be(0);

            deck.BuyCard(deck.VisibleDevelopments(Level.Level1).First());
            deck.VisibleDevelopments(Level.Level1).Count().Should().Be(3);
            deck.HiddenDevelopment(Level.Level1).Should().BeNull();
            deck.RemainigDeckCards(Level.Level1).Should().Be(0);

            deck.BuyCard(deck.VisibleDevelopments(Level.Level1).First());
            deck.VisibleDevelopments(Level.Level1).Count().Should().Be(2);
            deck.HiddenDevelopment(Level.Level1).Should().BeNull();
            deck.RemainigDeckCards(Level.Level1).Should().Be(0);

            deck.BuyCard(deck.VisibleDevelopments(Level.Level1).First());
            deck.VisibleDevelopments(Level.Level1).Count().Should().Be(1);
            deck.HiddenDevelopment(Level.Level1).Should().BeNull();
            deck.RemainigDeckCards(Level.Level1).Should().Be(0);

            var lastCard = deck.VisibleDevelopments(Level.Level1).First();

            deck.BuyCard(lastCard);
            deck.VisibleDevelopments(Level.Level1).Count().Should().Be(0);
            deck.HiddenDevelopment(Level.Level1).Should().BeNull();
            deck.RemainigDeckCards(Level.Level1).Should().Be(0);

            Action action = () => deck.BuyCard(lastCard);
            action.Should().Throw<NotFoundException>();
        }

        [Fact]
        public void Should_remain_consistent_deck_after_taking_all_but_2_level_1_cards()
        {
            while (deck.RemainigDeckCards(Level.Level1) > 2)
            {
                var development = deck.VisibleDevelopments(Level.Level1).First();
                deck.BuyCard(development);
            }

            deck.VisibleDevelopments(Level.Level1).Count().Should().Be(Deck.VisibleDevelopmentsPerRow);
            deck.RemainigDeckCards(Level.Level1).Should().Be(2);
        }

        [Fact]
        public void Should_obtain_face_down_development()
        {
            var development = deck.HiddenDevelopment(Level.Level1);

            deck.IsVisible(development).Should().BeFalse();
        }
    }
}
