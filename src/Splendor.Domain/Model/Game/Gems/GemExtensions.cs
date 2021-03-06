﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Splendor.Domain
{
    public static class GemExtensions
    {
        public static IEnumerable<Gem> Get(this Gem gem, int x)
        {
            if (x < 0)
                return new List<Gem>();

            return Enumerable.Range(0, x).Select(i => gem).ToList();
        }

        public static bool AllSame(this IEnumerable<Gem> gems)
        {
            if (!gems.Any())
                return false;

            return gems.Distinct().Count() == 1;
        }


        public static bool AllDifferent(this IEnumerable<Gem> gems)
        {
            if (!gems.Any())
                return false;

            return gems.Distinct().Count() == gems.Count();
        }

        public static string JoinList(this IEnumerable<Gem> gems)
        {
            return string.Join(", ", gems.ListOfStrings());
        }

        private static IEnumerable<string> ListOfStrings(this IEnumerable<Gem> gems)
        {
            foreach (var gem in gems.Distinct())
            {
                int number = gems.Count(x => x == gem);
                yield return $"{gem.ToString(number)}";
            }
        }
    }
}
