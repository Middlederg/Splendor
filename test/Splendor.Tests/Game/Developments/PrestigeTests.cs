using Splendor.Domain;
using System;
using Xunit;
using FluentAssertions;

namespace Splendor.Tests
{
    public class PrestigeTests
    {
        private readonly Prestige four = Prestige.FromScalar(4);
        private readonly Prestige five = Prestige.FromScalar(5);
        private readonly Prestige zero = Prestige.Zero;
        private readonly Prestige one = Prestige.FromScalar(1);

        [Fact]
        public void Should_check_prestige_values()
        {
            four.ToString().Should().Be("4 pts");
            five.ToString().Should().Be("5 pts");
            zero.ToString().Should().Be("0 pts");
            one.ToString().Should().Be("1 pt");
        }

        [Fact]
        public void Should_compare_prestige_values()
        {
            four.Should().NotBe(five);
            zero.Should().NotBe(one);

            (four > one).Should().BeTrue();
            (four > 1).Should().BeTrue();
            (five >= 5).Should().BeTrue();
            (zero > five).Should().BeFalse();
            (zero > 5).Should().BeFalse();
        }

        [Fact]
        public void Should_check_explicit_conversion()
        {
            var otherFour = (Prestige)4;

            otherFour.Should().Be(four);
        }

        [Fact]
        public void Should_not_instantiate_lower_than_0()
        {
            Action action = () => Prestige.FromScalar(-1);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Should_add_prestige_values()
        {
            var sum = four + one;
            sum.Should().BeEquivalentTo(five);

            sum = four + zero;
            sum.Should().BeEquivalentTo(four);
        }
    }
}
