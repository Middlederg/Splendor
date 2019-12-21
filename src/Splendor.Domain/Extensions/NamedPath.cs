namespace Splendor.Domain
{
    public class NamedPath : IPath
    {
        public string Path { get; }

        public NamedPath(string name)
        {
            Path = name;
        }
    }
}
