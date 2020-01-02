using Splendor.Domain;
using System;

namespace Splendor.Forms
{
    public class DevelopmentEventArgs : EventArgs
    {
        public Development Development { get; }

        public DevelopmentEventArgs(Development development)
        {
            Development = development;
        }
    }
}
