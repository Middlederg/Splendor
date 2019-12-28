using Splendor.Domain;
using System;

namespace Splendor.Forms
{
    public class GemEventArgs : EventArgs
    {
        public Gem Gem { get; }

        public GemEventArgs(Gem gem)
        {
            Gem = gem;
        }
    }
}
