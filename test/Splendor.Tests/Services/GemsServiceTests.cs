using Xunit;
using Splendor.Domain;

namespace Splendor.Tests
{
    [Collection(nameof(DefaultCollection))]
    public class GemsServiceTests
    {
        private Game game;
        public GemsServiceTests()
        {
            game = new Game(Prestige.FromScalar(15),
                (Avatars.Danilo, ColorFactory.DefaultBlue),
                (Avatars.Debra, ColorFactory.Gray));
        }

        public void ShouldAddGems()
        {
            var service = new TakeGemsService(game.CurrentPlayer, game.Market, Gems.Onyx, Gems.Sapphire);
            //service.CanBeTaken
        }
    }
}
