namespace Splendor.Domain
{
    public class Turn
    {
        private readonly int startingPlayer;
        private readonly int playerCount;

        public int CurrentPlayer { get; private set; }
        public void NextTurn()
        {
            CurrentPlayer = (CurrentPlayer == playerCount - 1) ? 0 : CurrentPlayer + 1;
            if (CurrentPlayer == startingPlayer)
            {
                TurnNumber++;
            }
        }

        public int TurnNumber { get; private set; }
        public bool SameTurnsForAllPlayers => CurrentPlayer == startingPlayer;

        public Turn(int playerCount)
        {
            this.playerCount = playerCount;
            startingPlayer = Randomizer.GetRandomNumber(0, playerCount - 1);
            CurrentPlayer = startingPlayer;
            TurnNumber = 1;
        }
    }
}
