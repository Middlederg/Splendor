using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class Cost
    {
        private readonly IEnumerable<Gem> gems;
        public int Total => gems.Count();

        public Cost(params Gem[] gems)
        {
            this.gems = gems.ToList();
        }

        public Cost(params IEnumerable<Gem>[] gems)
        {
            this.gems = gems.SelectMany(x => x).ToList();
        }

        public int OfType(Gem gem) => gems.Count(x => x == gem);
    }
}
