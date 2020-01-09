namespace Splendor.Domain
{
    public class GameParticipant : Person
    {
        public int Points { get; private set; }
        public int DevelopmentCount { get; private set; }

        public GameParticipant(string name, bool isHuman = false) : base(name, isHuman)
        {
            Points = 0;
            DevelopmentCount = 0;
        }
    }
}
