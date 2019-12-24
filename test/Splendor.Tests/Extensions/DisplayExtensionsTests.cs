using Xunit;
using FluentAssertions;
using System;

namespace Splendor.Tests
{
    public enum State
    {
        [Display(Name = "Opened display")]
        Opened,

        Closed,
    }

    public class DisplayExtensionsTests
    {
        [Fact]
        public void Should_show_display_attribute()
        {
            var opened = State.Opened;
            opened.DisplayName().Should().Be("Opened display");

            var closed = State.Closed;
            closed.DisplayName().Should().Be("Closed");
        }
    }
}
