namespace Splendor.Domain
{
    public class NamedPath : IPath
    {
        public static NamedPath DevelopmentBack(Level level) => new NamedPath($"trasera{(int)level}");

        public string Path { get; }

        public NamedPath(string name)
        {
            Path = name;
        }
    }
}
