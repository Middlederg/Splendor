using Xunit;
using FluentAssertions;
using Splendor.Domain;

namespace Splendor.Tests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void Should_test_plurals()
        {
            3.IsPlural().Should().BeTrue();
            1.IsPlural().Should().BeFalse();
        }
    }
}
