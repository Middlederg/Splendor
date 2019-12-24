using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public static class ProfileExtensions
    {
        public static IEnumerable<Player> CreatePlayers(this IEnumerable<Profile> profiles)
        {
            int i = 0;
            return profiles.Select(profile => {
                i++;
                return new Player(i, profile);
            }).ToList();
        }    
    }
}
