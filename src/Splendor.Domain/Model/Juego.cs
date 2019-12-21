using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class Juego
    {
        /// <summary>
        /// Lista de desarrollos
        /// </summary>
        private List<Development> Mazo;

        public int Id { get; private set; }

        /// <summary>
        /// Lista de jugadores. Jugador siempre en posición 0
        /// </summary>
        public List<Jugador> Jugadores { get; set; }

        /// <summary>
        /// Lista de nobles (Número de jugadores + 1)
        /// </summary>
        public List<Noble> Nobles { get; set; }        

        /// <summary>
        /// Gemas que se pueden coger de la mesa
        /// </summary>
        public List<Gem> GemasMesa { get; set; }

        /// <summary>
        /// Indica qué jugador tiene el turno
        /// </summary>
        public int Turno { get; set; }

        /// <summary>
        /// Puntuación que determina el final de la partida. Por defecto 15
        /// </summary>
        public int PuntuacionObjetivo { get; set; }

        /// <summary>
        /// Detalle de jugadas realizadas hasta ahora
        /// </summary>
        public List<string> Log { get; set; }

        public Action UpdateDesarrollos { get; set; }
        public Action UpdateNobles { get; set; }
        public Action UpdateGemas { get; set; }
        public Action UpdateJugadores { get; set; }

        public Juego(Silueta[] siluetas, int puntuacionObjetivo)
        {
            Jugadores = new List<Jugador>();
            for (int i = 0; i < siluetas.Length; i++)
                Jugadores.Add(new Jugador(i, siluetas[i]));

            Log = new List<string> { $"Comienza el juego. Partida a {Jugadores.Count} jugadores" };
            PuntuacionObjetivo = puntuacionObjetivo;
            ResetGame();
        }

        /// <summary>
        /// Reinicia el juego
        /// </summary>
        public void ResetGame()
        {
            Id++;
            if (Id > 1) Log.Add("Partida reiniciada"); 
            Jugadores.ForEach(x=> x.Reset());
            Turno = GameFactory.PrepararJugadorInicial(Jugadores.Count);
            Log.Add($"{Jugadores[Turno].ToString()} comienza la partida");

            //Preparo los nobles 
            Nobles = NoblesFactory.GetNobles(Jugadores.Count + 1).ToList();

            //Preparo el mazo de desarrollos
            Mazo = DesarrollosFactory.GetDesarrollos().ToList();
            GemasMesa = new List<Gem>();

            //Reparto oro dependiendo del número de jugadores
            foreach (int i in Enumerable.Range(0, Gems.GetNumGemasInicio(Jugadores.Count).oro))
                GemasMesa.Add(Gems.Gold);

            //Reparto gemas dependiendo del número de jugadores
            foreach (var gema in Gems.GetAllGems(includeGold:false))
                foreach (int i in Enumerable.Range(0, Gems.GetNumGemasInicio(Jugadores.Count).gemas))
                    GemasMesa.Add(gema);
        }

        /// <summary>
        /// Devuelve si es el turno del jugador 1
        /// </summary>
        /// <returns></returns>
        public bool TurnoDelJugador => Turno == 0;

        /// <summary>
        /// Devuelve el jugador que tiene el turno
        /// </summary>
        /// <returns></returns>
        public Jugador ElTurno() => Jugadores[Turno];

        /// <summary>
        /// Devuelve lista de jugadores excepto uno
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Jugador> RestoJugadores(Jugador jug) => Jugadores.Where(x => !x.Equals(jug));

        /// <summary>
        /// El turno pasa al siguiente jugador
        /// </summary>
        public void AvanzaTurno() => Turno = (Turno == Jugadores.Count - 1) ? 0 : Turno + 1;

        /// <summary>
        /// Todos los jugadores han hecho su jugada ese turno
        /// </summary>
        /// <returns></returns>
        public bool TurnoCompletado() => Jugadores.Select(x => x.TurnosJugados).Distinct().Count() == 1;

        /// <summary>
        /// Comprueba si ha terminado la partida, y si lo ha hecho devuelve al ganador
        /// </summary>
        /// <returns></returns>
        public Jugador FinalPartida() => (Jugadores.Any(x => x.Prestigio() >= PuntuacionObjetivo) && TurnoCompletado()) ? Clasificacion().First() : null;
            
        /// <summary>
        /// Devuelve el orden de jugadores en la partida
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Jugador> Clasificacion() => Jugadores.OrderByDescending(x => x.Prestigio()).ThenBy(y => y.Desarrollos.Count);

        #region Nobles

        /// <summary>
        /// El jugador recibe el noble indicado
        /// Por defecto, el noble lo recibe el jugador con el turno
        /// </summary>
        /// <param name="noble"></param>
        /// <param name="jugadorActivo"></param>
        public void RecibirNoble(Noble noble, Jugador jugadorActivo = null)
        {
            if (jugadorActivo == null) jugadorActivo = ElTurno();
            jugadorActivo.NoblesVisitados.Add(noble);
            Nobles.Remove(noble);
            Log.Add((jugadorActivo == null ? jugadorActivo : ElTurno()).Nombre + " recibe la visita de " + noble.ToString());
            UpdateNobles.Invoke();
        }

        /// <summary>
        /// Obtiene una lista con los nobles que pueden visitar ese turno a un jugador
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public IEnumerable<Noble> PosiblesNoblesVisitados(Jugador jug) => Nobles.Where(x => x.Visitable(jug));

        #endregion

        #region Desarrollos

        /// <summary>
        /// El jugador compra el desarrollo indicado
        /// Por defecto, el desarrollo lo compra el jugador con el turno
        /// </summary>
        /// <param name="desarrollo"></param>
        /// <param name="jugadorActivo"></param>
        public void CompraDesarrollo(Development desarrollo, Jugador jugadorActivo = null)
        {
            if (jugadorActivo == null) jugadorActivo = ElTurno();
            GemasMesa.AddRange(jugadorActivo.Comprar(desarrollo));
            Mazo.Remove(desarrollo);
            Log.Add($"{jugadorActivo.Nombre} compra {desarrollo.ToString()}");
            UpdateDesarrollos();
            UpdateGemas();
            UpdateJugadores();
        }

        /// <summary>
        /// El jugador reserva el desarrollo indicado
        /// Por defecto, el desarrollo lo reserva el jugador con el turno
        /// </summary>
        /// <param name="desarrollo"></param>
        /// <param name="jugadorActivo"></param>
        public void ReservaDesarrollo(Development desarrollo, Jugador jugadorActivo = null)
        {
            if (jugadorActivo == null) jugadorActivo = ElTurno();
            jugadorActivo.Reservadas.Add(desarrollo);
            Mazo.Remove(desarrollo);
            string textoOro = ", pero no quedan monedas de oro.";
            if (NumGemasMesa(Gems.Gold) > 0)
            {
                textoOro = ", y consigue una moneda de oro";
                jugadorActivo.Gemas.Add(Gems.Gold);
                GemasMesa.Remove(Gems.Gold);
            }
            Log.Add(jugadorActivo.Nombre + " reserva " + desarrollo.ToString() + textoOro);
            UpdateDesarrollos();
            UpdateJugadores();
            UpdateGemas();
        }

        public IEnumerable<Development> DesarrollosVisibles()
        {
            foreach (int nivel in Enumerable.Range(1, 3))
                foreach (var d in DesarrollosVisibles((NivelDesarrollo)nivel))
                    yield return d;
        }

        /// <summary>
        /// Muestra desarrollos visibles para ese nivel de desarrollos
        /// </summary>
        /// <param name="nivel"></param>
        /// <returns></returns>
        public IEnumerable<Development> DesarrollosVisibles(NivelDesarrollo nivel) => Mazo.Where(x => x.Nivel == nivel).Take(4);

        public int CartasMazo(NivelDesarrollo nivel) => Math.Max(0, Mazo.Count(x => x.Nivel == nivel) - 4);

        #endregion

        #region Gemas

        /// <summary>
        /// Devuelve la cantidad de gemas que hay sobre la mesa de ese tipo de gema
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public int NumGemasMesa(Gem gema) => GemasMesa.Count(x => x.Equals(gema));

        /// <summary>
        /// Devuelve si un jugador puede coger una gema de ese tipo
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public bool PuedeCogerUnaGema(Gem gema) => GemasMesa.Contains(gema);

        /// <summary>
        /// Devuelve lista de monedas que puede coger el jugador si coge 3 gemas
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public IEnumerable<Gem> PuedeCogerUnaGema() => Gems.GetAllGems(includeGold: false).Where(gema => GemasMesa.Contains(gema));

        /// <summary>
        /// Devuelve si un jugador puede coger dos gema de ese tipo
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public bool PuedeCogerDosGemas(Gem gema) => NumGemasMesa(gema) >= 4;

        /// <summary>
        /// Devuelve lista de monedas que puede coger el jugador si coge 2 gemas iguales
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public IEnumerable<Gem> PuedeCogerDosGemas() => Gems.GetAllGems(includeGold: false).Where(gema => PuedeCogerDosGemas(gema));

        /// <summary>
        /// El jugador activo coge una lista de gemas
        /// </summary>
        /// <param name="gemas"></param>
        public void CogerGemas(IEnumerable<Gem> gemas, Jugador jugadorActivo = null)
        {
            if (jugadorActivo == null) jugadorActivo = ElTurno();
            jugadorActivo.Gemas.AddRange(gemas);
            gemas.ToList().ForEach(x => GemasMesa.Remove(x));
            if(gemas.Distinct().Count() > 1)
                Log.Add(jugadorActivo.Nombre + " coge " + string.Join(", ", gemas.Select(x=> x.ToString())));
            else
                Log.Add(jugadorActivo.Nombre + " coge " + gemas.Distinct().Count() + " " + gemas.First().ToString());
            UpdateGemas();
            UpdateJugadores();
        }

        #endregion


        /// <summary>
        /// Simula una partida completa
        /// </summary>
        public void Simulacion()
        {
            while (FinalPartida() == null)
            {
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

        #region InteligenciaArtificial

        public IAccion Mover(Jugador jugadorActivo = null)
        {
            if (jugadorActivo == null) jugadorActivo = ElTurno();

            //Opción 1: comprar desarrollo
            Development d = BuscaDesarrollo();
            if (d != null)
            {
                CompraDesarrollo(d);

                //Busca si es visitado por un noble.
                var n = RecibirNoble();
                if (n != null)
                    Log.Add($"{jugadorActivo.Nombre} recibe la visita de {n.ToString()}");
                
                return new ComprarDesarrollo(d, n);
            }

            //Coge 3 gemas al azar
            if (jugadorActivo.TotalGemas() < 6)
            {
                var gemas3 = PuedeCogerUnaGema().GetRandomItems(3);
                CogerGemas(gemas3);
                return new CogerGemas(gemas3);
            }

            //Reservar desarrollo con moneda de oro
            if (jugadorActivo.PuedeReservar() && NumGemasMesa(Gems.Gold) > 0)
            {
                var res = ReservaDesarrollo();
                if (res != null)
                {
                    ReservaDesarrollo(res);
                    return new ReservarDesarrollo(res, conPiezaOro : true);
                }
            }

            //Coge 2 gemas al azar
            if (jugadorActivo.TotalGemas() < 9 && PuedeCogerDosGemas().Any())
            {
                var gema = PuedeCogerDosGemas().GetRandomItem();
                var gemas2 = new List<Gem> { gema, gema };
                CogerGemas(gemas2);
                return new CogerGemas(gemas2);
            }

            //Reservar desarrollo sin moneda de oro
            if (jugadorActivo.PuedeReservar())
            {
                var res = ReservaDesarrollo();
                if (res != null)
                {
                    ReservaDesarrollo(res);
                    return new ReservarDesarrollo(res, conPiezaOro : false);
                }
            }

            var gemas = PuedeCogerUnaGema().GetRandomItems(3);
            CogerGemas(gemas);
            return new CogerGemas(gemas);
        }

        /// <summary>
        /// Busca el desarrollo que es más idoneo comprar 
        /// (Por defecto, para el jugador que posee el turno)
        /// </summary>
        /// <param name="jugadorActivo"></param>
        /// <returns></returns>
        public Development BuscaDesarrollo(Jugador jugadorActivo = null)
        {
            if (jugadorActivo == null)
                jugadorActivo = ElTurno();

            //Obtiene lista de desarrollos comprables
            var desarrollos = DesarrollosVisibles().Where(d => d.ComprableConOro(jugadorActivo));
            if (desarrollos == null || !desarrollos.Any())
                return null;

            //1 Bbusca si comprar alguno de ellos le hace ganar la partida
            if (jugadorActivo.Prestigio() + desarrollos.Max(x => x.Prestigio) >= PuntuacionObjetivo)
                return desarrollos.OrderByDescending(x => x.Prestigio).FirstOrDefault();

            //2 Busca si alguno le hace ganar la partida a un rival
            foreach(Jugador rival in Jugadores.Where(x=> !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
            {
                Development d = rival.VictoriaSegura(desarrollos, PuntuacionObjetivo);
                if (d != null) return d;
            }

            //3 Busca si alguno le sale gratis
            if (desarrollos.Concat(jugadorActivo.Reservadas).Any(x => x.Gratuito(jugadorActivo)))
                return (desarrollos.Concat(jugadorActivo.Reservadas)).First();

            //4 busca cual podría adelantarse para comprarlo antes que un rival
            foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
            {
                Development d = rival.MejorDesarrollo(desarrollos);
                if (d != null) return d;
            }

            //5 busca el que menos oro o gemas le haga gastar
            Development des = jugadorActivo.MejorDesarrollo(desarrollos.Concat(jugadorActivo.Reservadas));
            return des;
        }

        /// <summary>
        /// Reserva el desarrollo más conveniente
        /// </summary>
        /// <param name="jugadorActivo"></param>
        /// <returns></returns>
        public Development ReservaDesarrollo(Jugador jugadorActivo = null)
        {
            if (jugadorActivo == null) jugadorActivo = ElTurno();

            //Obtiene lista de desarrollos visibles
            var desarrollos = DesarrollosVisibles();

            //1 Busca si alguno le hace ganar la partida a un rival
            foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
            {
                Development d = rival.VictoriaSegura(desarrollos, PuntuacionObjetivo);
                if (d != null) return d;
            }

            //2 Busca si alguno le sale gratis a un rival
            foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
            {
                Development d = desarrollos.FirstOrDefault(x => x.Gratuito(rival));
                if (d != null) return d;
            }

            //3 Busca cual podría adelantarse para reservarlo antes que un rival
            foreach (Jugador rival in Jugadores.Where(x => !x.Equals(jugadorActivo)).OrderBy(x => x.TurnosJugados))
            {
                Development d = rival.MejorDesarrollo(desarrollos);
                if (d != null) return d;
            }

            //4 Busca el que menos oro o gemas le haga gastar
            Development des = jugadorActivo.MejorDesarrollo(desarrollos);
            if (des != null) return des;

            return null;
        }

        //public List<Gema> listagemasConvienenAleatoria()
        //{
        //    List<Gema> l = new List<Gema>();
        //    for (int i = 1; i <= 5; i++)
        //        l.Add(new Gema(i));
        //    return Utilx.barajar<Gema>(l);
        //}

        //public List<Gema> GemasConvienen(Jugador jugadorActivo = null)
        //{
        //    //if (jugadorActivo == null) jugadorActivo = ElTurno();

        //    //foreach(Desarrollo d in jugadorActivo.MejoresDesarrollo(DesarrollosVisibles()))
        //    //{

        //    //}

        //    //GameHelper.ObtenerListaGemas()
        //    //List<Gema> l = new List<Gema>();
        //    //int[] porcentajes = new int[5];
        //    //foreach (Desarrollo d in desarrollosMostrados())
        //    //{
        //    //    int sum = 0;
        //    //    int i = 0;
        //    //    foreach (int precio in d.Precio)
        //    //    {
        //    //        sum += (precio - Jugadores[IndTurno].poder(i+1));
        //    //        i++;
        //    //    }
        //    //    for (int j = 0; j < 5; j++)
        //    //    {
        //    //        porcentajes[j] += (sum == 0) ? 0 : (d.Precio[j] - Jugadores[IndTurno].poder(j)) * 100 / sum;
        //    //    }
        //    //}

        //    //for (int i = 0; i < porcentajes.Length; i++)
        //    //{
        //    //    porcentajes[i] = porcentajes[i] / desarrollosMostrados().Count;
        //    //    if (porcentajes[i] == 0) //para no dejar ninguna gema con porcentaje 0
        //    //        porcentajes[i] = 1;
        //    //}

        //    ////ordenar gemas en funcion de los porcentajes
        //    //int[] intArray = {1,2,3,4,5};
        //    //Array.Sort(porcentajes, intArray);
        //    //Array.Reverse(intArray);

        //    //for (int i = 0; i < porcentajes.Length; i++)
        //    //    l.Add(new Gema(intArray[i]));

        //    //return l;
        //}

        /// <summary>
        /// Jugador activo recibe un noble y devuelve la elección
        /// </summary>
        public Noble RecibirNoble()
        {
            //Busca si es visitado por un noble.
            var misNobles = PosiblesNoblesVisitados(ElTurno());

            if (misNobles.Any())
            {
                foreach (Jugador rival in RestoJugadores(ElTurno()).OrderBy(x => x.TurnosJugados))
                {
                    Noble nob = misNobles.FirstOrDefault(x => x.Visitable(rival));
                    if (nob != null)
                    {
                        RecibirNoble(nob);
                        return nob;
                    }
                }
                return misNobles.First();
            }
            return null;
        }

        #endregion
    }
}
