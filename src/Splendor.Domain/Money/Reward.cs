namespace Splendor.Domain
{
    public class Reward
    {
        private readonly int objetive;

        public Reward(int objetive)
        {
            this.objetive = objetive;
        }

        public override string ToString() => $"Objetive : {objetive} points";
    }
}
