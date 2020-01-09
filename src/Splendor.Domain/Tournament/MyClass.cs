using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class TournamentParticipant : Person
    {
        public int Victories { get; private set; }
        public int Points { get; private set; }

        public TournamentParticipant(string name, bool isHuman = false) : base(name, isHuman)
        {
            Victories = 0;
            Points = 0;
        }
    }

    public class TournamentGame
    {
        public List<TournamentParticipant> Participants { get; private set; }
    }
}

public 

public class DiscountVale
{

}

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




public class Season
{
    public int Division { get; set; }
    public DateTime Fecha { get; set; }
    public List<Torneos> Torneos { get; set; }
    public List<Persona> Personas { get; set; }
    public List<Sponsor> Sponsors { get; set; }
    public List<Gift> Tienda { get; set; }

    public Season()
    {
        Division = 4;
        Torneos = DAL.obtenerTorneos();
        Personas = Datos.obtenerPersonas(500);
        Sponsors = DAL.obtenerSponsorsTemporada();
        Tienda = DAL.obtenerTodosLosObjetos();
    }

    public idTorneo celebrarSiguienteTorneo()
    {
        Torneo t = Torneos.Where(t => t.Division == Division).OrderBy(t2 => t2.Edicion).FirstOrDefault();
        Fecha = t.Fecha.AddDays(t.Rondas)

        return t.Id;
    }

    //Establece division inicial para todas las personas
    public void determinarDivision()
    {
        int div = 1;
        int count = 1;
        foreach (Persona p in Personas.OrderByDesc(v => v.media()).ToList())
        {
            p.Division = div;
            if (count > div * 100)
            {
                div++;
            }
            count++;
        }
    }


    public void actualizarDivisiones()
    {
        //ascensos
        int[] ascensos = new int[30];
        int index = 0;
        int puesto = 1;
        for (int div = 2; div <= 4; div++)
        {
            foreach (Persona p in
                Personas.Where(vD => vD.Division == div).
                OrderByDesc(v => v.victoriasAnuales()).
                ThenByDesc(v2 => v2.mediaPuntos()).TOList())
            {
                if (puesto < 10)
                {
                    ascensos[index] = p.IdPersona;
                    index++;
                }
                puesto++;
            }
            puesto = 1;
        }

        //descensos
        int[] descensos = new int[30];
        index = 0;
        int puesto = 1;
        for (int div = 1; div <= 3; div++)
        {
            foreach (Persona p in
                Personas.Where(vD => vD.Division == div).
                OrderByDesc(v => v.victoriasAnuales()).
                ThenByDesc(v2 => v2.mediaPuntos()).TOList())
            {
                if (puesto > 90)
                {
                    descensos[index] = p.IdPersona;
                    index++;
                }
                puesto++;
            }
            puesto = 1;
        }

        foreach (int i in ascensos)
            Personas.Where(vPer => vPer.Id == i).FirstOrDefault().Division++;
        foreach (int i in descensos)
            Personas.Where(vPer => vPer.Id == i).FirstOrDefault().Division--;
    }
}




public class Ranking
{
    public int IdMedalla { get; set; }
    public int Division { get; set; }
    public int IdTorneo { get; set; }
    public DateTime Fecha { get; set; }

    private string[] nombres = { "Oro", "Plata", "Bronce", "Diploma espléndido" };


    public Ranking(int idMedalla, int division, int idTorneo, DateTime fecha)
    {
        IdMedalla = idMedalla;
        Division = division;
        IdTorneo = idTorneo;
        Fecha = fecha;
    }

    public override ToString()
    {
        return nombres[IdMedalla - 1];
    }
}

public class Nota
{
    public int IdNota { get; set; }
    public string Descripcion { get; set; }
    public string SubDescripcion { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    public Nota(int id, string desc, string subdesc, DateTime fIni, dateTime fFin)
    {
        IdNota = id;
        Descripcion = desc;
        SubDescripcion = subdesc;
        FechaInicio = fIni;
        FechaFin = fFin;
    }
}


public class Ranking
{
    public int IdPersona { get; set; }
    public int Puntos { get; set; }
    public bool Victoria { get; set; }
    public int IdTorneo { get; set; }
    public int Division { get; set; }
    public DateTime Fecha { get; set; }

    public Ranking(int idPers, int ptos, bool vict, int idTorneo, int division, DateTime fecha)
    {
        idPersona = idPers;
        Puntos = ptos;
        Victoria = vict;
        IdTorneo = idTorneo;
        Division = division;
        Fecha = fecha;
    }
}



public static class Estadisticas
{
    public static List<Ranking> ElRanking;

    static Estadisticas()
    {
        ElRanking = new List<Ranking>();
    }

    public static int victorias(int idPersona, int idTor, DateTime fec)
    {
        int victs = 0;
        List<Ranking> l = ElRanking.Where(v => v.IdPersona == idPer);

        //torneo
        if (idTor != -1)
            l = l.Where(v => v.IdTorneo == idTor);

        //año
        if (idTor != -1)
            l = l.Where(v => v.Fecha.Year == fec.Year);

        foreach (Ranking r in l)
        {
            victs += (r.Victoria) ? 1 : 0;
        }
        return victs;
    }

    public static int numPartidas(int idPersona, int idTor, DateTime fec)
    {
        int num = 0;
        List<Ranking> l = ElRanking.Where(v => v.IdPersona == idPer);

        //torneo
        if (idTor != -1)
            l = l.Where(v => v.IdTorneo == idTor);

        //año
        if (idTor != -1)
            l = l.Where(v => v.Fecha.Year == fec.Year);

        foreach (Ranking r in l)
        {
            num++;
        }
        return num;
    }

    public static int numTorneosJugados(int idPersona, DateTime fec)
    {
        List<Ranking> l = ElRanking.Where(v => v.IdPersona == idPer);

        //año
        if (idTor != -1)
            l = l.Where(v => v.Fecha.Year == fec.Year);

        int count = l.GroupBy(test => test.IdTorneo).Count();

        return count;
    }

    public static double mediaPuntos(int idPersona, int idTor, DateTime fec)
    {
        int num = 0;
        List<Ranking> l = ElRanking.Where(v => v.IdPersona == idPer);

        //torneo
        if (idTor != -1)
            l = l.Where(v => v.IdTorneo == idTor);

        //año
        if (idTor != -1)
            l = l.Where(v => v.Fecha.Year == fec.Year);

        foreach (Ranking r in l)
        {
            num += r.Puntos;
        }
        return double(num / numPartidas(idPersona, idTor, fec));
    }



    public static double victoriasPorTorneo(int idPersona, DateTime fec)
    {
        int num = 0;
        victorias(idPersona, -1, fec) /


        foreach (Ranking r in l)
        {
            num += r.Puntos;
        }
        return double(num / numTorneosJugados(idPersona, year);
    }


}



public class Tienda
{
    public List<Gift> Articulos { get; set; }
    public List<Gift> Carrito { get; set; }

    public Tienda(int nivel)
    {
        Articulos = DAL.obtenerArticulos(nivel);
        Carrito = new List<Gift>();
    }
}





}