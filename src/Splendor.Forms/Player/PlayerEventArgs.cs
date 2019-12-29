using Splendor.Domain;
using System;

namespace Splendor.Forms
{
    public class PlayerEventArgs : EventArgs
    {
        public Player Player { get; }

        public PlayerEventArgs(Player player)
        {
            Player = player;
        }
    }
}
