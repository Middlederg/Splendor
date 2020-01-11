using Splendor.Domain;
using System;
using Xunit;
using FluentAssertions;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class LevelTests
    {
        private readonly Level one;
        private readonly Level two;
        private readonly Level three;

        public LevelTests()
        {
            one = Level.Level1;
            two = Level.Level2;
            three = Level.Level3;
        }

        [Fact]
        public void Should_check_level_values()
        {
            one.ToString().Should().Be("Level 1");
            two.ToString().Should().Be("Level 2");
            three.ToString().Should().Be("Level 3");
        }

        [Fact]
        public void Should_compare_level_values()
        {
            one.Should().NotBe(two);
            two.Should().NotBe(three);

            (one == (Level)1).Should().BeTrue();
            (one == (Level)2).Should().BeFalse();
            (two == (Level)2).Should().BeTrue();

            Level.FromScalar(1).Should().Be(one);
        }

        [Fact]
        public void Should_check_explicit_level_conversion()
        {
            var otherOne = (Level)1;

            otherOne.Should().Be(one);
        }

        [Fact]
        public void Should_only_instantiate_values_between_1_and_3()
        {
            Action action1 = () => Level.FromScalar(0);
            Action action2 = () => Level.FromScalar(4);
            action1.Should().Throw<ArgumentOutOfRangeException>();
            action2.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
