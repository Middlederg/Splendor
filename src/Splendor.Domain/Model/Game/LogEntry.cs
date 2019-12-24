namespace Splendor.Domain
{
    public class LogEntry
    {
        public int Turn { get; }
        public Move Move { get; }
        public Player Player { get; }

        public LogEntry(int turn, Move move, Player player)
        {
            Turn = turn;
            Move = move;
            Player = player;
        }

        public override string ToString() => $"{Turn}\t{Player.ToString()}: {Move.ToString()}";
    }
}
