using System.Drawing;
using Xunit;
using Splendor.Domain;
using FluentAssertions;

namespace Splendor.Tests
{
    public class ColorTests
    {
        [Fact]
        public void ShouldDarkenColor()
        {
            var color = Color.FromArgb(100, 101, 102);

            var darkerColor = color.Darken(12);

            darkerColor.Should().BeEquivalentTo(Color.FromArgb(88, 89, 90));
        }

        [Fact]
        public void ShouldNotDarkenBlack()
        {
            var color = Color.Black;

            var darkerColor = color.Darken(12);

            darkerColor.Should().BeEquivalentTo(Color.FromArgb(0, 0, 0));
        }

        [Fact]
        public void ShouldLightenColor()
        {
            var color = Color.FromArgb(100, 101, 102);

            var lighterColor = color.Lighten(12);

            lighterColor.Should().BeEquivalentTo(Color.FromArgb(112, 113, 114));
        }

        [Fact]
        public void ShouldNotLightenWhite()
        {
            var color = Color.White;

            var ligtherColor = color.Lighten(12);

            ligtherColor.Should().BeEquivalentTo(Color.FromArgb(255, 255, 255));
        }
    }
}
