using System.Collections.Generic;
using System.Linq;
using Splendor.Core.Model;

namespace Splendor.Core.Negocio
{
    public static class GemasFactory
    {
        /// <summary>
        /// Lista con las cinco gemas ordenadas (Diamante, Rubi, Onix, Zafiro, Esmeralda)
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Gema> GetListaGemas()
        {
            foreach (int i in Enumerable.Range(1, 5))
                yield return (Gema)i;
        }

        /// <summary>
        /// Lista con oro + las cinco gemas ordenadas (Oro, Diamante, Rubi, Onix, Zafiro, Esmeralda)
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Gema> GetListaGemasOro()
        {
            foreach (int i in Enumerable.Range(0, 6))
                yield return (Gema)i;
        }

        /// <summary>
        /// Devuelve Pareja con oro y gemas Dependiendo del número de jugadores
        /// </summary>
        /// <param name="numJugadores"></param>
        /// <returns></returns>
        public static (int oro, int gemas) GetNumGemasInicio(int numJugadores)
        {
            switch (numJugadores)
            {
                case 4:
                    return (5, 7);
                case 3:
                    return (5, 5);
            }
            return (5, 4);
        }
    }
}
