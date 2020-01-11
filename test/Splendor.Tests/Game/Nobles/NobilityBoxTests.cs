using FluentAssertions;
using Splendor.Domain;
using System;
using System.Linq;
using Xunit;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class NobilityBoxTests
    {
        [Fact]
        public void Should_create_box_with_5_different_nobles()
        {
            var box = new NobilityBox(4);
            box.RemainigNobles.Should().Be(5);

            var count = box.NobleList.Distinct().Count();
            count.Should().Be(box.RemainigNobles);
        }

        [Fact]
        public void Should_remove_noble_from_box()
        {
            var box = new NobilityBox(3);
            box.RemainigNobles.Should().Be(4);

            var nobleToRemove = box.NobleList.First();
            box.Remove(nobleToRemove);

            box.RemainigNobles.Should().Be(3);
            box.NobleList.Should().NotContain(nobleToRemove);
        }
    }
}
