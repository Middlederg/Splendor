using System.Collections.Generic;

namespace Splendor.Domain
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
