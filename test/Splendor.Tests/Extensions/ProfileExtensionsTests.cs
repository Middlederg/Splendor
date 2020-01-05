using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using Splendor.Domain;
using System.Linq;

namespace Splendor.Tests
{
    public class ProfileExtensionsTests
    {
        [Fact]
        public void Should_create_two_players()
        {
            var profiles = new List<(Avatar avatar, ColorGroup color)>()
            {
                (new Avatar(1, "first"), ColorFactory.DefaultBlue),
                (new Avatar(2, "second"), ColorFactory.Orange)
            };

            var players = profiles.CreatePlayers();
            players.Count().Should().Be(2);
            players.ElementAt(0).Id.Should().Be(1);
            players.ElementAt(1).Id.Should().Be(2);
            players.ElementAt(0).ToString().Should().Be("first");
            players.ElementAt(1).ToString().Should().Be("second");

            foreach (var player in players)
            {
                player.ReservedDevelopments.Should().BeEmpty();
                player.Developments.Should().BeEmpty();
                player.Gems.Should().BeEmpty();
                player.Moves.Should().BeEmpty();
                player.Prestige.Should().Be((Prestige)0);
                player.TotalDevelopments.Should().Be(0);
                player.VisitedNobles.Should().BeEmpty();
            }
        }
    }
}
