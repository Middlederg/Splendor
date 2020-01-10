using System.Collections.Generic;

namespace Splendor.Domain
{
    public class GameSimulation
    {
        private IEnumerable<GameParticipant> participants;

        public GameSimulation(params GameParticipant[] participants)
        {
            this.participants = participants;
        }

        public void Simulate()
        {

        }
    }
}
