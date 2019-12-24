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
        private readonly Turn turn;
        private readonly NobilityBox nobilityBox;
        private readonly Deck deck;
        private readonly Market market;
        private readonly Log log;

        public List<Player> Players { get; }
        public Prestige Objetive { get; }

        public Game(Prestige objetive, params Profile[] profiles)
        {
            Players = profiles.CreatePlayers().ToList();
            Objetive = objetive;

            turn = new Turn(profiles.Count());
            nobilityBox = new NobilityBox(profiles.Count());
            deck = new Deck();

            var (gold, gems) = Gems.GetNumGemasInicio(profiles.Count());
            market = new Market(gems, gold);

            log = new Log();
        }

        public Game ResetGame() => new Game(Objetive, Players.Select(x => x.Profile).ToArray());

        public Player CurrentPlayer => Players[turn.CurrentPlayer];
        public IEnumerable<Player> OtherPlayers(Player player) => Players.Where(x => x != player);


        public bool IsGameEnd() => Players
            .Any(x => x.Prestige >= Objetive
            && turn.SameTurnsForAllPlayers);


        public IEnumerable<Player> Ranking() => Players
            .OrderByDescending(x => x.Prestige)
            .ThenBy(y => y.Developments.Count());

        public void Simulate()
        {
            while (!IsGameEnd())
            {
                var player = CurrentPlayer;

                foreach (Jugador jug in Jugadores)
                {
                    Mover();
                    AvanzaTurno();
                }
            }
            Log.Add("GANADOR: " + FinalPartida().Nombre);
            foreach (var jug in Clasificacion())
                Log.Add((Clasificacion().ToList().IndexOf(jug) + 1) + ". " + jug.ToString());
        }



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
