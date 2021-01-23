using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public static class Randomizer
    {
        private static readonly Random random = new Random(DateTime.Now.Millisecond);
        public static int GetRandomNumber(int inf, int sup) => random.Next(inf, sup + 1);
        public static T GetRandomItem<T>(this IEnumerable<T> lista)
        {
            if (lista == null || !lista.Any())
                return default;

            return lista.ElementAt(GetRandomNumber(0, lista.Count() - 1));
        }

        public static IEnumerable<T> GetRandomItems<T>(this IEnumerable<T> lista, int count) => Enumerable.Range(0, count).Select(x => lista.GetRandomItem());
        public static IEnumerable<T> RandomizeList<T>(this List<T> list)
        {
            List<T> auxiliar = new List<T>();

            int count = list.Count();
            for (int i = 0; i < count; i++)
            {
                int pos = random.Next(0, list.Count);
                T o = list[pos];
                auxiliar.Add(o);
                list.Remove(o);
            }
            return auxiliar;
        }
    }


}
