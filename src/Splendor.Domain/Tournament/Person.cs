namespace Splendor.Domain
{
    public class Person
    {
        private readonly string name;
        public bool IsHuman { get; }

        public Person(string name, bool isHuman = false)
        {
            this.name = name;
            IsHuman = isHuman;
        }

        public override string ToString() => name;
    }
}
