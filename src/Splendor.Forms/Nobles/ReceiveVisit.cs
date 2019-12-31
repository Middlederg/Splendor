using Splendor.Domain;
using Splendor.Forms.Views;
using System.Linq;

namespace Splendor.Forms
{
    public class ReceiveVisit
    {
        private readonly NobilityBox nobilityBox;
        private readonly Player player;

        public ReceiveVisit(NobilityBox nobilityBox,Player player)
        {
            this.nobilityBox = nobilityBox;
            this.player = player;
        }

        public Noble Receive()
        {
            var nobilityService = new NobilityService(nobilityBox, player);
            var potencialNobles = nobilityService.CanReceiveVisitFrom();
            if(potencialNobles.Any())
            {
                using (var noblesView = new NoblesView(potencialNobles))
                {
                    noblesView.ShowDialog();
                    var chosenNoble = noblesView.SelectedNoble;
                    nobilityService.ReceiveVisit(chosenNoble);
                    return chosenNoble;
                }
            }
            return null;
        }
    }
}
