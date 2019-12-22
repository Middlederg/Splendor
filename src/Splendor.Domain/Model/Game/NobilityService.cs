using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class NobilityService
    {
        private readonly NobilityBox box;
        private readonly Player player;

        public NobilityService(NobilityBox box, Player player)
        {
            this.box = box;
            this.player = player;
        }

        public IEnumerable<Noble> CanVisit()
        {
            foreach (var noble in box.NobleList)
            {
                bool visitable = Gems.GetAllGems().All(gem => player.Bonus(gem) >= noble.RequiredQuantity(gem));
                if (visitable)
                {
                    yield return noble;
                }
            }
        }

        public void Visit(Noble noble)
        {
            box.Remove(noble);
            player.AddNoble(noble);
        }
    }
}
