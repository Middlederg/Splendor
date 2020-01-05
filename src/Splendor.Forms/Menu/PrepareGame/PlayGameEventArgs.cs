using Splendor.Domain;
using System;
using System.Collections.Generic;

namespace Splendor.Forms
{
    public class PlayGameEventArgs : EventArgs
    {
        public Prestige Objetive { get; }
        public IEnumerable<(Avatar avatar, ColorGroup color)> Players { get; }

        public PlayGameEventArgs(Prestige objetive, IEnumerable<(Avatar avatar, ColorGroup color)> players)
        {
            Objetive = objetive;
            Players = players;
        }
    }
}
