namespace Splendor.Domain
{
    public class Gift
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public bool Conseguido { get; set; }

        public Gift(int id, string nom, string desc, int precio)
        {
            Id = id;
            Nombre = nom;
            Descripcion = desc;
            Precio = precio;
            Conseguido = false;
        }
    }
}
