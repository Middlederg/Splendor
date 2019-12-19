using System;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Core.Negocio
{

    public static class GameFactory
    {
        /// <summary>
        /// Sortea el jugador inicial de la partida
        /// </summary>
        /// <param name="numjugadores"></param>
        /// <returns></returns>
        public static int PrepararJugadorInicial(int numJugadores) =>  Randomizer.GetRandomNumber(0, numJugadores - 1);
    }
}
