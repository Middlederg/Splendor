using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{

    public class Game
    {
        private int turn;
        private readonly Market market;
        private readonly Deck deck;
        private NobilityBox nobilityBox;

        public List<Player> Players { get; }
        public Prestige Objetive { get; }

        public IEnumerable<Move> GetAllmoves() => Players.SelectMany(x => x.Moves);

        public Game(Prestige objetive, params Profile[] profiles)
        {
            int i = 0;
            profiles.Select(profile => {
                i++;
                return new Player(i, profile);
            });

            turn = Randomizer.GetRandomNumber(0, profiles.Count() - 1);

            Objetive = objetive;

            nobilityBox = new NobilityBox(profiles.Count());
            deck = new Deck();

            var (gold, gems) = Gems.GetNumGemasInicio(profiles.Count());
            market = new Market(gems, gold);
        }

        public Game ResetGame() => new Game(Objetive, Players.Select(x => x.Profile).ToArray());


        public Player CurrentPlayer => Players[turn];
        public IEnumerable<Player> OtherPlayers(Player player) => Players.Where(x => x != player);

        public void NextTurn() => turn = (turn == Players.Count - 1) ? 0 : turn + 1;

        ///// <summary>
        ///// Comprueba si ha terminado la partida, y si lo ha hecho devuelve al ganador
        ///// </summary>
        ///// <returns></returns>
        //public Jugador FinalPartida() => (Jugadores.Any(x => x.Prestigio() >= PuntuacionObjetivo) && TurnoCompletado()) ? Clasificacion().First() : null;
            
        ///// <summary>
        ///// Devuelve el orden de jugadores en la partida
        ///// </summary>
        ///// <returns></returns>
        //public IEnumerable<Jugador> Clasificacion() => Jugadores.OrderByDescending(x => x.Prestigio()).ThenBy(y => y.Desarrollos.Count);

  

        ///// <summary>
        ///// El jugador recibe el noble indicado
        ///// Por defecto, el noble lo recibe el jugador con el turno
        ///// </summary>
        ///// <param name="noble"></param>
        ///// <param name="jugadorActivo"></param>
        //public void RecibirNoble(Noble noble, Jugador jugadorActivo = null)
        //{
        //    if (jugadorActivo == null) jugadorActivo = ElTurno();
        //    jugadorActivo.NoblesVisitados.Add(noble);
        //    Nobles.Remove(noble);
        //    Log.Add((jugadorActivo == null ? jugadorActivo : ElTurno()).Nombre + " recibe la visita de " + noble.ToString());
        //    UpdateNobles.Invoke();
        //}




        ///// <summary>
        ///// El jugador compra el desarrollo indicado
        ///// Por defecto, el desarrollo lo compra el jugador con el turno
        ///// </summary>
        ///// <param name="desarrollo"></param>
        ///// <param name="jugadorActivo"></param>
        //public void CompraDesarrollo(Development desarrollo, Jugador jugadorActivo = null)
        //{
        //    if (jugadorActivo == null) jugadorActivo = ElTurno();
        //    GemasMesa.AddRange(jugadorActivo.Comprar(desarrollo));
        //    Mazo.Remove(desarrollo);
        //    Log.Add($"{jugadorActivo.Nombre} compra {desarrollo.ToString()}");
        //    UpdateDesarrollos();
        //    UpdateGemas();
        //    UpdateJugadores();
        //}







        ///// <summary>
        ///// Devuelve la cantidad de gemas que hay sobre la mesa de ese tipo de gema
        ///// </summary>
        ///// <param name="gema"></param>
        ///// <returns></returns>
        //public int NumGemasMesa(Gem gema) => GemasMesa.Count(x => x.Equals(gema));

        ///// <summary>
        ///// Devuelve si un jugador puede coger una gema de ese tipo
        ///// </summary>
        ///// <param name="gema"></param>
        ///// <returns></returns>
        //public bool PuedeCogerUnaGema(Gem gema) => GemasMesa.Contains(gema);

        ///// <summary>
        ///// Devuelve lista de monedas que puede coger el jugador si coge 3 gemas
        ///// </summary>
        ///// <param name="gema"></param>
        ///// <returns></returns>
        //public IEnumerable<Gem> PuedeCogerUnaGema() => Gems.GetAllGems().Where(gema => GemasMesa.Contains(gema));

        ///// <summary>
        ///// Devuelve si un jugador puede coger dos gema de ese tipo
        ///// </summary>
        ///// <param name="gema"></param>
        ///// <returns></returns>
        //public bool PuedeCogerDosGemas(Gem gema) => NumGemasMesa(gema) >= 4;

        ///// <summary>
        ///// Devuelve lista de monedas que puede coger el jugador si coge 2 gemas iguales
        ///// </summary>
        ///// <param name="gema"></param>
        ///// <returns></returns>
        //public IEnumerable<Gem> PuedeCogerDosGemas() => Gems.GetAllGems().Where(gema => PuedeCogerDosGemas(gema));

        ///// <summary>
        ///// El jugador activo coge una lista de gemas
        ///// </summary>
        ///// <param name="gemas"></param>
        //public void CogerGemas(IEnumerable<Gem> gemas, Jugador jugadorActivo = null)
        //{
        //    if (jugadorActivo == null) jugadorActivo = ElTurno();
        //    jugadorActivo.Gemas.AddRange(gemas);
        //    gemas.ToList().ForEach(x => GemasMesa.Remove(x));
        //    if(gemas.Distinct().Count() > 1)
        //        Log.Add(jugadorActivo.Nombre + " coge " + string.Join(", ", gemas.Select(x=> x.ToString())));
        //    else
        //        Log.Add(jugadorActivo.Nombre + " coge " + gemas.Distinct().Count() + " " + gemas.First().ToString());
        //    UpdateGemas();
        //    UpdateJugadores();
        //}




        ///// <summary>
        ///// Simula una partida completa
        ///// </summary>
        //public void Simulacion()
        //{
        //    while (FinalPartida() == null)
        //    {
        //        foreach (Jugador jug in Jugadores)
        //        {
        //            Mover();
        //            AvanzaTurno();
        //        }
        //    }
        //    Log.Add("GANADOR: " + FinalPartida().Nombre);
        //    foreach (var jug in Clasificacion())
        //        Log.Add((Clasificacion().ToList().IndexOf(jug) + 1) + ". " + jug.ToString());
        //}



        //public IAccion Mover(Jugador jugadorActivo = null)
        //{
        //    if (jugadorActivo == null) jugadorActivo = ElTurno();

        //    //Opción 1: comprar desarrollo
        //    Development d = BuscaDesarrollo();
        //    if (d != null)
        //    {
        //        CompraDesarrollo(d);

        //        //Busca si es visitado por un noble.
        //        //var n = RecibirNoble();
        //        //if (n != null)
        //        //    Log.Add($"{jugadorActivo.Nombre} recibe la visita de {n.ToString()}");
                
        //        //return new ComprarDesarrollo(d, n);
        //    }

        //    //Coge 3 gemas al azar
        //    if (jugadorActivo.TotalGemas() < 6)
        //    {
        //        var gemas3 = PuedeCogerUnaGema().GetRandomItems(3);
        //        CogerGemas(gemas3);
        //        return new CogerGemas(gemas3);
        //    }

        //    //Reservar desarrollo con moneda de oro
        //    if (jugadorActivo.PuedeReservar() && NumGemasMesa(Gems.Gold) > 0)
        //    {
        //        var res = ReservaDesarrollo();
        //        if (res != null)
        //        {
        //            ReservaDesarrollo(res);
        //            return new ReservarDesarrollo(res, conPiezaOro : true);
        //        }
        //    }

        //    //Coge 2 gemas al azar
        //    if (jugadorActivo.TotalGemas() < 9 && PuedeCogerDosGemas().Any())
        //    {
        //        var gema = PuedeCogerDosGemas().GetRandomItem();
        //        var gemas2 = new List<Gem> { gema, gema };
        //        CogerGemas(gemas2);
        //        return new CogerGemas(gemas2);
        //    }

        //    //Reservar desarrollo sin moneda de oro
        //    if (jugadorActivo.PuedeReservar())
        //    {
        //        var res = ReservaDesarrollo();
        //        if (res != null)
        //        {
        //            ReservaDesarrollo(res);
        //            return new ReservarDesarrollo(res, conPiezaOro : false);
        //        }
        //    }

        //    var gemas = PuedeCogerUnaGema().GetRandomItems(3);
        //    CogerGemas(gemas);
        //    return new CogerGemas(gemas);
        //}

        ///// <summary>
        ///// Busca el desarrollo que es más idoneo comprar 
        ///// (Por defecto, para el jugador que posee el turno)
        ///// </summary>
        ///// <param name="jugadorActivo"></param>
        ///// <returns></returns>
        //public Development BuscaDesarrollo(Jugador jugadorActivo = null)
        //{
        //    if (jugadorActivo == null)
        //        jugadorActivo = ElTurno();

        //    //Obtiene lista de desarrollos comprables
        //    var desarrollos = DesarrollosVisibles().Where(d => d.ComprableConOro(jugadorActivo));
        //    if (desarrollos == null || !desarrollos.Any())
        //        return null;

        //    //1 Bbusca si comprar alguno de ellos le hace ganar la partida
        //    if (jugadorActivo.Prestigio() + desarrollos.Max(x => x.Prestige) >= PuntuacionObjetivo)
        //        return desarrollos.OrderByDescending(x => x.Prestige).FirstOrDefault();

        //    //2 Busca si alguno le hace ganar la partida a un rival
        //    foreach(Jugador rival in Jugadores.Where(x=> !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
        //    {
        //        Development d = rival.VictoriaSegura(desarrollos, PuntuacionObjetivo);
        //        if (d != null) return d;
        //    }

        //    //3 Busca si alguno le sale gratis
        //    if (desarrollos.Concat(jugadorActivo.Reservadas).Any(x => x.Gratuito(jugadorActivo)))
        //        return (desarrollos.Concat(jugadorActivo.Reservadas)).First();

        //    //4 busca cual podría adelantarse para comprarlo antes que un rival
        //    foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
        //    {
        //        Development d = rival.MejorDesarrollo(desarrollos);
        //        if (d != null) return d;
        //    }

        //    //5 busca el que menos oro o gemas le haga gastar
        //    Development des = jugadorActivo.MejorDesarrollo(desarrollos.Concat(jugadorActivo.Reservadas));
        //    return des;
        //}

        ///// <summary>
        ///// Reserva el desarrollo más conveniente
        ///// </summary>
        ///// <param name="jugadorActivo"></param>
        ///// <returns></returns>
        //public Development ReservaDesarrollo(Jugador jugadorActivo = null)
        //{
        //    if (jugadorActivo == null) jugadorActivo = ElTurno();

        //    //Obtiene lista de desarrollos visibles
        //    var desarrollos = DesarrollosVisibles();

        //    //1 Busca si alguno le hace ganar la partida a un rival
        //    foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
        //    {
        //        Development d = rival.VictoriaSegura(desarrollos, PuntuacionObjetivo);
        //        if (d != null) return d;
        //    }

        //    //2 Busca si alguno le sale gratis a un rival
        //    foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
        //    {
        //        Development d = desarrollos.FirstOrDefault(x => x.Gratuito(rival));
        //        if (d != null) return d;
        //    }

        //    //3 Busca cual podría adelantarse para reservarlo antes que un rival
        //    foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
        //    {
        //        Development d = rival.MejorDesarrollo(desarrollos);
        //        if (d != null) return d;
        //    }

        //    //4 Busca el que menos oro o gemas le haga gastar
        //    Development des = jugadorActivo.MejorDesarrollo(desarrollos);
        //    if (des != null) return des;

        //    return null;
        //}

       

        /// <summary>
        /// Jugador activo recibe un noble y devuelve la elección
        /// </summary>
        //public Noble RecibirNoble()
        //{
        //    //Busca si es visitado por un noble.
        //    var misNobles = PosiblesNoblesVisitados(ElTurno());

        //    if (misNobles.Any())
        //    {
        //        foreach (Jugador rival in RestoJugadores(ElTurno()).OrderBy(x => x.TurnosJugados))
        //        {
        //            Noble nob = misNobles.FirstOrDefault(x => x.Visitable(rival));
        //            if (nob != null)
        //            {
        //                RecibirNoble(nob);
        //                return nob;
        //            }
        //        }
        //        return misNobles.First();
        //    }
        //    return null;
        //}
    }
}
