using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class NobilityBox
    {
        public const int VisibleDevelopmentsPerRow = 4;

        public List<Noble> NobleList { get; }
        public int RemainigNobles => NobleList.Count();

        private Action updateNobles;
        public void Subscribe(Action action) => updateNobles += action;

        public NobilityBox(int playerCount)
        {
            NobleList = Nobles.GetNobles(playerCount + 1).ToList();
        }

        public void Remove(Noble noble)
        {
            var taken = NobleList.Remove(noble);
            if (!taken)
                throw new NotFoundException(nameof(Development));

            updateNobles?.Invoke();
        }
    }
}
