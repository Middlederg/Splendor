namespace Splendor.Domain
{
    public class DevelopmentBack : IPath
    {
        public Level Nivel { get; }

        public string Path => $"trasera{Nivel.LevelNumber}";

        public DevelopmentBack(Level nivel)
        {
            Nivel = nivel;
        }
    }
}
