public class Sponsor
{
    private readonly int id;
    private readonly string name;

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Nivel { get; set; }
    public int[] Regalos { get; set; }
    public int PrecioVictoria { get; set; }
    public int PrecioTorneo { get; set; }
    public int PrecioMedalla { get; set; }
    public int ValeDescuento { get; set; }

    public Sponsor(int id, string nom, string desc, int nivel, int[] reg,
    int precioVictoria, int precioTorneo, int precioMedalla, int disc)
    {
        Id = id;
        Nombre = nom;
        Descripcion = desc;
        Nivel = nivel;
        PrecioVictoria = precioVictoria;
        PrecioTorneo = precioTorneo;
        PrecioMedalla = precioMedalla;
        Regalos = reg;
        ValeDescuento = disc;
    }

    public override string ToString() => name;
}
