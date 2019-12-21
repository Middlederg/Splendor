namespace Splendor.Domain
{
    public class DevelopmentBack : IPath
    {
        public NivelDesarrollo Nivel { get; }

        public string Path => $"trasera{(int)Nivel}";

        public DevelopmentBack(NivelDesarrollo nivel)
        {
            Nivel = nivel;
        }
    }
}
