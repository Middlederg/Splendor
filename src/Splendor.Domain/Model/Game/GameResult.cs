namespace Splendor.Domain
{
    public class GameResult
    {
        public int Position { get; }
        public string PlayerName { get; }
        public Prestige Prestige { get; }
        public int Developments { get; }

        public GameResult(int position, string playerName, Prestige prestige, int developments)
        {
            Position = position;
            PlayerName = playerName;
            Prestige = prestige;
            Developments = developments;
        }
    }
}
