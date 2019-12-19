using System.Collections.Generic;
using System.Linq;
using Splendor.Core.Model;
using System.Collections;
using System;

namespace Splendor.Core.Negocio
{
    public static class NoblesFactory
    {
        /// <summary>
        /// Devuelve todos los Nobles disponibles
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Noble> GetNobles()
        {
            return new List<Noble>
            {
                new Noble("Isabel La Católica", new int[] { 4, 0, 4, 0, 0 }, 3, "IsabelLaCatolica"),
                new Noble("Carlos V", new int[] { 3, 3, 3, 0, 0 }, 3, "CarlosV"),
                new Noble("Ana de Gran Bretaña", new int[] { 3, 0, 0, 3, 3 }, 3, "AnaGB"),
                new Noble("Francisco I de Francia", new int[] { 0, 3, 3, 0, 3 }, 3, "FranciscoFrancia"),
                new Noble("Catalina de Medici", new int[] { 0, 3, 0, 3, 3 }, 3, "CatalinaMedici"),
                new Noble("María Estuardo", new int[] { 0, 4, 0, 0, 4 }, 3, "MariaEstuardo"),
                new Noble("Nicolás de Machiavello", new int[] { 4, 0, 0, 4, 0 }, 3, "Machiavello"),
                new Noble("Enrique VIII", new int[] { 0, 4, 4, 0, 0 }, 3, "Henry8"),
                new Noble("Solimán El Magnífico", new int[] { 0, 0, 0, 4, 4 }, 3, "SolimanElMagnifico"),
                new Noble("Isabel de Baviera", new int[] { 3, 0, 3, 3, 0 }, 3, "IsabelBaviera")
            };
        }

        public static IEnumerable<Noble> GetNobles(int numero) => GetNobles().GetRandomItems(numero);
    }
}
