using System.Collections.Generic;
using System.Linq;
using Splendor.Core.Enumeraciones;
using Splendor.Core.Model;
using System;

namespace Splendor.Core.Negocio
{
    public static class DesarrollosFactory
    {
        public static IEnumerable<Desarrollo> GetDesarrollos() => ListaDesarrollos().ToList().RandomizeList();
        /// <summary>
        /// Devuelve todos los Desarrollos disponibles barajados
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Desarrollo> ListaDesarrollos()
        {
            IEnumerable<Desarrollo> l = new List<Desarrollo>
            {
                #region NIVEL 1
                //Diamante
                new Desarrollo(1, 1, new int[] { 0, 0, 2, 2, 0 }, 0, Gema.Diamante, "d7"),
                new Desarrollo(2, 1, new int[] { 3, 0, 1, 1, 0 }, 0, Gema.Diamante, "d3"),
                new Desarrollo(3, 1, new int[] { 0, 0, 1, 2, 2 }, 0, Gema.Diamante, "d2"),
                new Desarrollo(4, 1, new int[] { 0, 1, 1, 1, 1 }, 0, Gema.Diamante, "d4"),
                new Desarrollo(5, 1, new int[] { 0, 0, 0, 0, 4 }, 1, Gema.Diamante, "d5"),
                new Desarrollo(6, 1, new int[] { 0, 2, 1, 0, 0 }, 0, Gema.Diamante, "d6"),
                new Desarrollo(7, 1, new int[] { 0, 1, 1, 1, 2 }, 0, Gema.Diamante, "d1"),
                new Desarrollo(8, 1, new int[] { 0, 0, 0, 3, 0 }, 0, Gema.Diamante, "d8"),

                //Rubi
                new Desarrollo(9, 1, new int[] { 2, 2, 0, 0, 0 }, 0, Gema.Rubi, "r3"),
                new Desarrollo(10, 1, new int[] { 1, 1, 3, 0, 0 }, 0, Gema.Rubi, "r6"),
                new Desarrollo(11, 1, new int[] { 2, 0, 2, 0, 1 }, 0, Gema.Rubi, "r7"),
                new Desarrollo(12, 1, new int[] { 1, 0, 1, 1, 1 }, 0, Gema.Rubi, "r5"),
                new Desarrollo(13, 1, new int[] { 4, 0, 0, 0, 0 }, 1, Gema.Rubi, "r4"),
                new Desarrollo(14, 1, new int[] { 0, 0, 0, 2, 1 }, 0, Gema.Rubi, "r1"),
                new Desarrollo(15, 1, new int[] { 2, 0, 1, 1, 1 }, 0, Gema.Rubi, "r8"),
                new Desarrollo(16, 1, new int[] { 3, 0, 0, 0, 0 }, 0, Gema.Rubi, "r2"),

                //Onix
                new Desarrollo(17, 1, new int[] { 2, 0, 0, 0, 2 }, 0, Gema.Onix, "o3"),
                new Desarrollo(18, 1, new int[] { 0, 3, 1, 0, 1 }, 0, Gema.Onix, "o8"),
                new Desarrollo(19, 1, new int[] { 2, 1, 0, 2, 0 }, 0, Gema.Onix, "o7"),
                new Desarrollo(20, 1, new int[] { 1, 1, 0, 1, 1 }, 0, Gema.Onix, "o5"),
                new Desarrollo(21, 1, new int[] { 0, 0, 0, 4, 0 }, 1, Gema.Onix, "o4"),
                new Desarrollo(22, 1, new int[] { 0, 1, 0, 0, 2 }, 0, Gema.Onix, "o1"),
                new Desarrollo(23, 1, new int[] { 1, 1, 0, 2, 1 }, 0, Gema.Onix, "o6"),
                new Desarrollo(24, 1, new int[] { 0, 0, 0, 0, 3 }, 0, Gema.Onix, "o2"),

                //Zafiro
                new Desarrollo(25, 1, new int[] { 0, 0, 2, 0, 2 }, 0, Gema.Zafiro, "z5"),
                new Desarrollo(26, 1, new int[] { 0, 1, 0, 1, 3 }, 0, Gema.Zafiro, "z7"),
                new Desarrollo(27, 1, new int[] { 1, 2, 0, 0, 2 }, 0, Gema.Zafiro, "z1"),
                new Desarrollo(28, 1, new int[] { 1, 1, 1, 0, 1 }, 0, Gema.Zafiro, "z4"),
                new Desarrollo(29, 1, new int[] { 0, 4, 0, 0, 0 }, 1, Gema.Zafiro, "z6"),
                new Desarrollo(30, 1, new int[] { 1, 0, 2, 0, 0 }, 0, Gema.Zafiro, "z3"),
                new Desarrollo(31, 1, new int[] { 1, 2, 1, 0, 1 }, 0, Gema.Zafiro, "z8"),
                new Desarrollo(32, 1, new int[] { 0, 0, 3, 0, 0 }, 0, Gema.Zafiro, "z2"),

                //Esmeralda
                new Desarrollo(33, 1, new int[] { 0, 2, 0, 2, 0 }, 0, Gema.Esmeralda, "e4"),
                new Desarrollo(34, 1, new int[] { 1, 0, 0, 3, 1 }, 0, Gema.Esmeralda, "e8"),
                new Desarrollo(35, 1, new int[] { 0, 2, 2, 1, 0 }, 0, Gema.Esmeralda, "e6"),
                new Desarrollo(36, 1, new int[] { 1, 1, 1, 1, 0 }, 0, Gema.Esmeralda, "e3"),
                new Desarrollo(37, 1, new int[] { 0, 0, 4, 0, 0 }, 1, Gema.Esmeralda, "e5"),
                new Desarrollo(38, 1, new int[] { 2, 0, 0, 1, 0 }, 0, Gema.Esmeralda, "e2"),
                new Desarrollo(39, 1, new int[] { 1, 1, 2, 1, 0 }, 0, Gema.Esmeralda, "e7"),
                new Desarrollo(40, 1, new int[] { 0, 3, 0, 0, 0 }, 0, Gema.Esmeralda, "e1"),
	            #endregion

                #region NIVEL 2

                //Diamante
                new Desarrollo(41, 2, new int[] { 0, 5, 0, 0, 0 }, 2, Gema.Diamante, "d9"),
                new Desarrollo(42, 2, new int[] { 6, 0, 0, 0, 0 }, 3, Gema.Diamante, "d10"),
                new Desarrollo(43, 2, new int[] { 0, 2, 2, 0, 3 }, 1, Gema.Diamante, "d11"),
                new Desarrollo(44, 2, new int[] { 0, 4, 2, 0, 1 }, 2, Gema.Diamante, "d12"),
                new Desarrollo(45, 2, new int[] { 2, 3, 0, 3, 0 }, 1, Gema.Diamante, "d13"),
                new Desarrollo(46, 2, new int[] { 5, 0, 3, 0, 0 }, 2, Gema.Diamante, "d14"),

                //Rubí
                new Desarrollo(47, 2, new int[] { 0, 2, 3, 3, 0 }, 1, Gema.Rubi, "r9"),
                new Desarrollo(48, 2, new int[] { 3, 0, 5, 0, 0 }, 2, Gema.Rubi, "r10"),
                new Desarrollo(49, 2, new int[] { 2, 2, 3, 0, 0 }, 1, Gema.Rubi, "r11"),
                new Desarrollo(50, 2, new int[] { 0, 6, 0, 0, 0 }, 3, Gema.Rubi, "r12"),
                new Desarrollo(51, 2, new int[] { 1, 0, 0, 4, 2 }, 2, Gema.Rubi, "r13"),
                new Desarrollo(52, 2, new int[] { 0, 0, 5, 0, 0 }, 2, Gema.Rubi, "r14"),

                //Onix
                new Desarrollo(53, 2, new int[] { 3, 0, 2, 0, 3 }, 1, Gema.Onix, "o9"),
                new Desarrollo(54, 2, new int[] { 0, 3, 0, 0, 5 }, 2, Gema.Onix, "o10"),
                new Desarrollo(55, 2, new int[] { 5, 0, 0, 0, 0 }, 2, Gema.Onix, "o11"),
                new Desarrollo(56, 2, new int[] { 0, 0, 6, 0, 0 }, 3, Gema.Onix, "o12"),
                new Desarrollo(57, 2, new int[] { 3, 0, 0, 2, 2 }, 1, Gema.Onix, "o13"),
                new Desarrollo(58, 2, new int[] { 0, 2, 0, 1, 4 }, 2, Gema.Onix, "o14"),

                //Zafiro
                new Desarrollo(59, 2, new int[] { 0, 0, 0, 6, 0 }, 3, Gema.Zafiro, "z9"),
                new Desarrollo(60, 2, new int[] { 2, 1, 4, 0, 0 }, 2, Gema.Zafiro, "z10"),
                new Desarrollo(61, 2, new int[] { 0, 0, 0, 5, 0 }, 2, Gema.Zafiro, "z11"),
                new Desarrollo(62, 2, new int[] { 0, 0, 3, 2, 3 }, 1, Gema.Zafiro, "z12"),
                new Desarrollo(63, 2, new int[] { 5, 0, 0, 3, 0 }, 2, Gema.Zafiro, "z13"),
                new Desarrollo(64, 2, new int[] { 0, 3, 0, 2, 2 }, 1, Gema.Zafiro, "z14"),

                //Esmeralda
                new Desarrollo(65, 2, new int[] { 0, 0, 0, 0, 6 }, 3, Gema.Esmeralda, "e9"),
                new Desarrollo(66, 2, new int[] { 4, 0, 1, 2, 0 }, 2, Gema.Esmeralda, "e10"),
                new Desarrollo(67, 2, new int[] { 0, 0, 0, 0, 5 }, 2, Gema.Esmeralda, "e11"),
                new Desarrollo(68, 2, new int[] { 0, 0, 0, 5, 3 }, 2, Gema.Esmeralda, "e12"),
                new Desarrollo(69, 2, new int[] { 3, 3, 0, 0, 2 }, 1, Gema.Esmeralda, "e13"),
                new Desarrollo(70, 2, new int[] { 2, 0, 2, 3, 0 }, 1, Gema.Esmeralda, "e14"),

            	#endregion

                #region NIVEL 3

                //Diamante
                new Desarrollo(71, 3, new int[] { 0, 0, 7, 0, 0 }, 4, Gema.Diamante, "d15"),
                new Desarrollo(72, 3, new int[] { 3, 0, 7, 0, 0 }, 5, Gema.Diamante, "d16"),
                new Desarrollo(73, 3, new int[] { 0, 5, 3, 3, 3 }, 3, Gema.Diamante, "d17"),
                new Desarrollo(74, 3, new int[] { 3, 3, 6, 0, 0 }, 4, Gema.Diamante, "d18"),

                //Rubí
                new Desarrollo(75, 3, new int[] { 3, 0, 3, 5, 3 }, 3, Gema.Rubi, "r16"),
                new Desarrollo(76, 3, new int[] { 0, 3, 0, 0, 7 }, 5, Gema.Rubi, "r15"),
                new Desarrollo(77, 3, new int[] { 0, 0, 0, 0, 7 }, 4, Gema.Rubi, "r18"),
                new Desarrollo(78, 3, new int[] { 0, 3, 0, 3, 6 }, 4, Gema.Rubi, "r17"),

                //Onix
                new Desarrollo(79, 3, new int[] { 0, 7, 0, 0, 0 }, 4, Gema.Onix, "o16"),
                new Desarrollo(80, 3, new int[] { 0, 7, 3, 0, 0 }, 5, Gema.Onix, "o17"),
                new Desarrollo(81, 3, new int[] { 3, 3, 0, 3, 5 }, 3, Gema.Onix, "o15"),
                new Desarrollo(82, 3, new int[] { 0, 6, 3, 0, 3 }, 4, Gema.Onix, "o18"),

                //Zafiro
                new Desarrollo(83, 3, new int[] { 7, 0, 0, 0, 0 }, 4, Gema.Zafiro, "z18"),
                new Desarrollo(84, 3, new int[] { 7, 0, 0, 3, 0 }, 5, Gema.Zafiro, "z17"),
                new Desarrollo(85, 3, new int[] { 3, 3, 5, 0, 3 }, 3, Gema.Zafiro, "z15"),
                new Desarrollo(86, 3, new int[] { 6, 0, 3, 3, 0 }, 4, Gema.Zafiro, "z16"),

                //Esmeralda
                new Desarrollo(87, 3, new int[] { 0, 0, 0, 7, 0 }, 4, Gema.Esmeralda, "e18"),
                new Desarrollo(88, 3, new int[] { 0, 0, 0, 7, 3 }, 5, Gema.Esmeralda, "e15"),
                new Desarrollo(89, 3, new int[] { 5, 3, 3, 3, 0 }, 3, Gema.Esmeralda, "e16"),
                new Desarrollo(90, 3, new int[] { 3, 0, 0, 6, 3 }, 4, Gema.Esmeralda, "e17")

                #endregion
            };

            return l.ToList();
        }
    }
}
