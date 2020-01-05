using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public static class ProfileExtensions
    {
        public static IEnumerable<Player> CreatePlayers(this IEnumerable<(Avatar avatar, ColorGroup color)> items)
        {
            int i = 0;
            return items.Select(item => {
                i++;
                return new Player(i, item.avatar, item.color, i == 1);
            }).ToList();
        }    
    }
}
