using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public enum PlayersPerTable
    {
        Two = 2,
        Three = 3,
        Four = 4
    }

    public enum Division
    {
        Internacional = 1,
        Nacional = 2,
        Semiprofesional = 3,
        Aficionados = 4
    }

    public class GameParticipant : Person
    {
        public int Points { get; private set; }
        public int DevelopmentCount { get; private set; }

        public GameParticipant(string name, bool isHuman = false) : base(name, isHuman)
        {
            Points = 0;
            DevelopmentCount = 0;
        }
    }

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

    public class Tournament
    {
        private readonly int id;
        private readonly string name;
        private readonly int maxPlayers;

        public string Description { get; }
        public string Place { get; }
        public Division Division { get; }
        public DateTime Date { get; }
        public int Edition => Date.Year;
        public int Rounds { get; set; }
        public PlayersPerTable PlayersPerTable { get; }
        public List<TournamentParticipant> Participants { get; private set; }
        public void AddParticipant(TournamentParticipant participant)
        {
            if (Participants.Count > maxPlayers)
                throw new ArgumentOutOfRangeException($"Can not add more participants");

            Participants.Add(participant);
        }
        public List<Prize> Prizes { get; }

        public Tournament(int id, string name, string description, string place, Division division, DateTime date, int rounds,
            PlayersPerTable playersPerTable, int maxPlayers, params Prize[] prizes)
        {
            this.id = id;
            this.name = name;
            this.maxPlayers = maxPlayers;

            Description = description;
            Place = place;
            Division = division;
            Date = date;
            Rounds = rounds;
            PlayersPerTable = playersPerTable;

            Participants = new List<TournamentParticipant>();
            Sponsors = sponsors;
            Prizes = prizes.ToList();
        }

        public List<TournamentParticipant> Ranking() => Participants
            .OrderByDescending(participant => participant.Victories)
            .ThenByDescending(participant => participant.Points)
            .ToList();
        

        //devuelve lista de jugadores que jugaran partida del player 1
        public List<Participantes> celebrarJornada()
        {
            int count = 1;
            List<TournamentParticipant> resultado = new List<TournamentParticipant>();
            List<TournamentParticipant> partida = new List<TournamentParticipant>();
            foreach (TournamentParticipant par in Ranking())
            {
                partida.Add(par);
                if (count % PlayersPerTable == 0)
                {
                    //Si le toca jugar al jugador 1
                    if (partida.Where(vP => vP.DatosPersona.Id == 1).Count != 0)
                    {
                        resultado = partida;
                    }
                    else
                    {
                        simularPartida(partida);
                    }
                    partida = new List<TournamentParticipant>();
                }
                count++;
            }
            Ronda
    

    return resultado;
        }


        public void simularPartida(List<TournamentParticipant> parts)
        {
            int i = 0;
            int[] nombres = new int[parts.Count];
            int[] ids = new int[parts.Count];
            foreach (TournamentParticipant p in parts)
            {
                nombres[i] = p.DatosPersona.sobrenombre();
                ids[i] = p.DatosPersona.Id;
            }
            Juego j = new Juego(nombres, ids);


            while (j.finalPartida == null)
            {
                foreach (Jugador jug in j.Jugadores)
                {
                    mover();
                }
            }

            //Actualizar victorias y puntos
            parts.Where(vP => vP.Id == j.finalPartida().IdParticipante).FirstOrdefault().Victorias++;
            i = 0;
            foreach (Jugador jug in j.Jugadores)
            {
                parts[i].Puntos += jug.Prestigio;
                i++;
                Datos.ElRanking.Add(parts[i].DatosPersona.Id, jug.Prestigio, (jug.Id == j.finalPartida().Id), Id, Division, Edition)
    

    }

        public override string ToString() => name;
    }


    public override string ToString()
    {
        return Nombre + ", en " + Localidad.ToString();
    }

    public override bool Equals(Tournament t)
    {
        return (obtenerId() == t.obtenerid());
    }


}



public class Sponsor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Nivel { get; set; }
    public int[] Regalos { get; set; }
    public int PrecioVictoria { get; set; }
    public int PrecioTorneo { get; set; }
    public int PrecioMedalla { get; set; }
    public int Descuento { get; set; }

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
        Descuento = disc;
    }
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






primera columna, oro
debajo, menu, solo activado cuando es turno
-Gemas
-Desarrollos - (comprar o reservar)
-Reserva
Cinco columnas mas, con gemas y debajo cartas

Siempre activo:
Ver Rivales

    Tres columnas, una por cada rival
	-Superior
    Datos persona
    Datos torneo
    Datos temporada
	-Inferior
    Prestigio
	1 Gemas propias
	2 Bonificaciones
	3 Comodines
	1+2 poder total

    Detalle de desarrollos

Log Dialog






Pantalla Torneo
-Arriba
    Datos de torneo
-Dcha
    Clasificación

    puesto - nombre - victorias - puntos
-Centro
    Detalles de la persona, media torneo, media total


-Izquierda Menu

    Calendario con proxima jornada

    Detalles de premios torneo(ganancias, regalos)

    Histórico(Resultados de otros años)

Pantalla temporada

panel superior
-Año de la temporada, fecha (Season 2016, 21 de noviembre)
-Division en la que te encuentras(División aficionados)
-Datos del jugador 
- Equipo actual
- Tus sponsors oficiales

Izquierda
-Calendario con torneos
Tabla:
Fecha-Nombre Torneo-Division-Inscrito

Centro
- Detalle de torneo
    Nombre con División

    Localidad y Fechas
    Patrocinador

    Descripción
    Datos tecnicos: Rondas y jugadores por partida
    Premios

    nivel del torneo(indice calculado)

- Detalles Equipo

    Puedes estar en un equipo, o independiente.El equipo te pagara sueldo,
    te añadirá patrocinador obligado(solo 1), y te dará bonus de popularidad.

- Patrocinadores y sponsor
    Puedes recibir ofertas de patrocinadores, como llevar camisetas etc

    Pueden ofrecerte dinero anual por victorias y/o descuentos. Dependiento de la
    fecha ofrecerán mas dinero.Demasiados sponsors merman la popularidad.
	- Ofertas sponsors
	- Ver tus Sponsors (Ves tu ropa con publicidad y las condiciones del sponsor)
- Medallero
    Se desarrolla a lo largo de las temporadas un medallero.
    Cada vez que quedas 1/2/3 un torneo, se añade una medalla de oro/plata/bronce
    se van acumulando en diferentes niveles.
- Palmarés(por año)

    Resumen de todas las victorias conseguidas

    Resumen de ranking.posicion, media anual
- Acceder al ranking.Lista de puntos Sp(Escala calculada). Global de todas las divisions
   dentro del ranking, Datos del jugador.Detalle de victorias, media anual por partida, dinero, objetos ganados, popularidad...
	
- Propiedades.Puedes ver tus juegos. 
- Tienda.Comprar nuevos objetos.

Botones
-Salir
-Continuar.Label al lado con el siguiente torneo que se abriría
}
