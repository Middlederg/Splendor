using System;

namespace Splendor.Domain
{
    public class Move
    {
        public int Turn { get; }
        public MoveType Type { get; }

        public Move(int turn, MoveType type)
        {
            Turn = turn;
            Type = type;
        }

        public override string ToString() => $"{Turn}. {Type.DisplayName()}";
    }
}
