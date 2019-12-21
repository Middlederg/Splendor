namespace Splendor.Domain
{
    public class DevelopmentBack : IPath
    {
        public Level Nivel { get; }

        public string Path => $"trasera{(int)Nivel}";

        public DevelopmentBack(Level nivel)
        {
            Nivel = nivel;
        }
    }
}
