﻿using Splendor.Domain;
using System;
using Xunit;
using FluentAssertions;

namespace Splendor.Tests
{
    public class PrestigeTests
    {
        private readonly Prestige four;
        private readonly Prestige five;
        private readonly Prestige zero;
        private readonly Prestige one;

        public PrestigeTests()
        {
            four = Prestige.FromScalar(4);
            five = Prestige.FromScalar(5);
            zero = Prestige.FromScalar(0);
            one = Prestige.FromScalar(1);
        }

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
    }
}
