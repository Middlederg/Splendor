namespace Splendor.Domain
{
    public class TournamentParticipant : Person
    {
        public int Victories { get; private set; }
        public int Points { get; private set; }

        public TournamentParticipant(string name, bool isHuman = false) : base(name, isHuman)
        {
            Victories = 0;
            Points = 0;
        }
    }
}
