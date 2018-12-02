namespace Splendor.Core.Model
{
    public class Silueta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Silueta(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
