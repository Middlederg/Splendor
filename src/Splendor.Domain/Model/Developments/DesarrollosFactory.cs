using System.Collections.Generic;
using System.Linq;
using System;

namespace Splendor.Domain
{
    public static class DesarrollosFactory
    {
        public static IEnumerable<Development> GetDesarrollos() => ListaDesarrollos().ToList().RandomizeList();
        /// <summary>
        /// Devuelve todos los Desarrollos disponibles barajados
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Development> ListaDesarrollos()
        {
            IEnumerable<Development> l = new List<Development>
            {
                #region NIVEL 1
                //Diamond
                new Development(1, 1, new int[] { 0, 0, 2, 2, 0 }, 0, Gems.Diamond, "d7"),
                new Development(2, 1, new int[] { 3, 0, 1, 1, 0 }, 0, Gems.Diamond, "d3"),
                new Development(3, 1, new int[] { 0, 0, 1, 2, 2 }, 0, Gems.Diamond, "d2"),
                new Development(4, 1, new int[] { 0, 1, 1, 1, 1 }, 0, Gems.Diamond, "d4"),
                new Development(5, 1, new int[] { 0, 0, 0, 0, 4 }, 1, Gems.Diamond, "d5"),
                new Development(6, 1, new int[] { 0, 2, 1, 0, 0 }, 0, Gems.Diamond, "d6"),
                new Development(7, 1, new int[] { 0, 1, 1, 1, 2 }, 0, Gems.Diamond, "d1"),
                new Development(8, 1, new int[] { 0, 0, 0, 3, 0 }, 0, Gems.Diamond, "d8"),

                //Ruby
                new Development(9, 1, new int[] { 2, 2, 0, 0, 0 }, 0, Gems.Ruby, "r3"),
                new Development(10, 1, new int[] { 1, 1, 3, 0, 0 }, 0, Gems.Ruby, "r6"),
                new Development(11, 1, new int[] { 2, 0, 2, 0, 1 }, 0, Gems.Ruby, "r7"),
                new Development(12, 1, new int[] { 1, 0, 1, 1, 1 }, 0, Gems.Ruby, "r5"),
                new Development(13, 1, new int[] { 4, 0, 0, 0, 0 }, 1, Gems.Ruby, "r4"),
                new Development(14, 1, new int[] { 0, 0, 0, 2, 1 }, 0, Gems.Ruby, "r1"),
                new Development(15, 1, new int[] { 2, 0, 1, 1, 1 }, 0, Gems.Ruby, "r8"),
                new Development(16, 1, new int[] { 3, 0, 0, 0, 0 }, 0, Gems.Ruby, "r2"),

                //Onyx
                new Development(17, 1, new int[] { 2, 0, 0, 0, 2 }, 0, Gems.Onyx, "o3"),
                new Development(18, 1, new int[] { 0, 3, 1, 0, 1 }, 0, Gems.Onyx, "o8"),
                new Development(19, 1, new int[] { 2, 1, 0, 2, 0 }, 0, Gems.Onyx, "o7"),
                new Development(20, 1, new int[] { 1, 1, 0, 1, 1 }, 0, Gems.Onyx, "o5"),
                new Development(21, 1, new int[] { 0, 0, 0, 4, 0 }, 1, Gems.Onyx, "o4"),
                new Development(22, 1, new int[] { 0, 1, 0, 0, 2 }, 0, Gems.Onyx, "o1"),
                new Development(23, 1, new int[] { 1, 1, 0, 2, 1 }, 0, Gems.Onyx, "o6"),
                new Development(24, 1, new int[] { 0, 0, 0, 0, 3 }, 0, Gems.Onyx, "o2"),

                //Sapphire
                new Development(25, 1, new int[] { 0, 0, 2, 0, 2 }, 0, Gems.Sapphire, "z5"),
                new Development(26, 1, new int[] { 0, 1, 0, 1, 3 }, 0, Gems.Sapphire, "z7"),
                new Development(27, 1, new int[] { 1, 2, 0, 0, 2 }, 0, Gems.Sapphire, "z1"),
                new Development(28, 1, new int[] { 1, 1, 1, 0, 1 }, 0, Gems.Sapphire, "z4"),
                new Development(29, 1, new int[] { 0, 4, 0, 0, 0 }, 1, Gems.Sapphire, "z6"),
                new Development(30, 1, new int[] { 1, 0, 2, 0, 0 }, 0, Gems.Sapphire, "z3"),
                new Development(31, 1, new int[] { 1, 2, 1, 0, 1 }, 0, Gems.Sapphire, "z8"),
                new Development(32, 1, new int[] { 0, 0, 3, 0, 0 }, 0, Gems.Sapphire, "z2"),

                //Emerald
                new Development(33, 1, new int[] { 0, 2, 0, 2, 0 }, 0, Gems.Emerald, "e4"),
                new Development(34, 1, new int[] { 1, 0, 0, 3, 1 }, 0, Gems.Emerald, "e8"),
                new Development(35, 1, new int[] { 0, 2, 2, 1, 0 }, 0, Gems.Emerald, "e6"),
                new Development(36, 1, new int[] { 1, 1, 1, 1, 0 }, 0, Gems.Emerald, "e3"),
                new Development(37, 1, new int[] { 0, 0, 4, 0, 0 }, 1, Gems.Emerald, "e5"),
                new Development(38, 1, new int[] { 2, 0, 0, 1, 0 }, 0, Gems.Emerald, "e2"),
                new Development(39, 1, new int[] { 1, 1, 2, 1, 0 }, 0, Gems.Emerald, "e7"),
                new Development(40, 1, new int[] { 0, 3, 0, 0, 0 }, 0, Gems.Emerald, "e1"),
	            #endregion

                #region NIVEL 2

                //Diamond
                new Development(41, 2, new int[] { 0, 5, 0, 0, 0 }, 2, Gems.Diamond, "d9"),
                new Development(42, 2, new int[] { 6, 0, 0, 0, 0 }, 3, Gems.Diamond, "d10"),
                new Development(43, 2, new int[] { 0, 2, 2, 0, 3 }, 1, Gems.Diamond, "d11"),
                new Development(44, 2, new int[] { 0, 4, 2, 0, 1 }, 2, Gems.Diamond, "d12"),
                new Development(45, 2, new int[] { 2, 3, 0, 3, 0 }, 1, Gems.Diamond, "d13"),
                new Development(46, 2, new int[] { 5, 0, 3, 0, 0 }, 2, Gems.Diamond, "d14"),

                //Rubí
                new Development(47, 2, new int[] { 0, 2, 3, 3, 0 }, 1, Gems.Ruby, "r9"),
                new Development(48, 2, new int[] { 3, 0, 5, 0, 0 }, 2, Gems.Ruby, "r10"),
                new Development(49, 2, new int[] { 2, 2, 3, 0, 0 }, 1, Gems.Ruby, "r11"),
                new Development(50, 2, new int[] { 0, 6, 0, 0, 0 }, 3, Gems.Ruby, "r12"),
                new Development(51, 2, new int[] { 1, 0, 0, 4, 2 }, 2, Gems.Ruby, "r13"),
                new Development(52, 2, new int[] { 0, 0, 5, 0, 0 }, 2, Gems.Ruby, "r14"),

                //Onyx
                new Development(53, 2, new int[] { 3, 0, 2, 0, 3 }, 1, Gems.Onyx, "o9"),
                new Development(54, 2, new int[] { 0, 3, 0, 0, 5 }, 2, Gems.Onyx, "o10"),
                new Development(55, 2, new int[] { 5, 0, 0, 0, 0 }, 2, Gems.Onyx, "o11"),
                new Development(56, 2, new int[] { 0, 0, 6, 0, 0 }, 3, Gems.Onyx, "o12"),
                new Development(57, 2, new int[] { 3, 0, 0, 2, 2 }, 1, Gems.Onyx, "o13"),
                new Development(58, 2, new int[] { 0, 2, 0, 1, 4 }, 2, Gems.Onyx, "o14"),

                //Sapphire
                new Development(59, 2, new int[] { 0, 0, 0, 6, 0 }, 3, Gems.Sapphire, "z9"),
                new Development(60, 2, new int[] { 2, 1, 4, 0, 0 }, 2, Gems.Sapphire, "z10"),
                new Development(61, 2, new int[] { 0, 0, 0, 5, 0 }, 2, Gems.Sapphire, "z11"),
                new Development(62, 2, new int[] { 0, 0, 3, 2, 3 }, 1, Gems.Sapphire, "z12"),
                new Development(63, 2, new int[] { 5, 0, 0, 3, 0 }, 2, Gems.Sapphire, "z13"),
                new Development(64, 2, new int[] { 0, 3, 0, 2, 2 }, 1, Gems.Sapphire, "z14"),

                //Emerald
                new Development(65, 2, new int[] { 0, 0, 0, 0, 6 }, 3, Gems.Emerald, "e9"),
                new Development(66, 2, new int[] { 4, 0, 1, 2, 0 }, 2, Gems.Emerald, "e10"),
                new Development(67, 2, new int[] { 0, 0, 0, 0, 5 }, 2, Gems.Emerald, "e11"),
                new Development(68, 2, new int[] { 0, 0, 0, 5, 3 }, 2, Gems.Emerald, "e12"),
                new Development(69, 2, new int[] { 3, 3, 0, 0, 2 }, 1, Gems.Emerald, "e13"),
                new Development(70, 2, new int[] { 2, 0, 2, 3, 0 }, 1, Gems.Emerald, "e14"),

            	#endregion

                #region NIVEL 3

                //Diamond
                new Development(71, 3, new int[] { 0, 0, 7, 0, 0 }, 4, Gems.Diamond, "d15"),
                new Development(72, 3, new int[] { 3, 0, 7, 0, 0 }, 5, Gems.Diamond, "d16"),
                new Development(73, 3, new int[] { 0, 5, 3, 3, 3 }, 3, Gems.Diamond, "d17"),
                new Development(74, 3, new int[] { 3, 3, 6, 0, 0 }, 4, Gems.Diamond, "d18"),

                //Rubí
                new Development(75, 3, new int[] { 3, 0, 3, 5, 3 }, 3, Gems.Ruby, "r16"),
                new Development(76, 3, new int[] { 0, 3, 0, 0, 7 }, 5, Gems.Ruby, "r15"),
                new Development(77, 3, new int[] { 0, 0, 0, 0, 7 }, 4, Gems.Ruby, "r18"),
                new Development(78, 3, new int[] { 0, 3, 0, 3, 6 }, 4, Gems.Ruby, "r17"),

                //Onyx
                new Development(79, 3, new int[] { 0, 7, 0, 0, 0 }, 4, Gems.Onyx, "o16"),
                new Development(80, 3, new int[] { 0, 7, 3, 0, 0 }, 5, Gems.Onyx, "o17"),
                new Development(81, 3, new int[] { 3, 3, 0, 3, 5 }, 3, Gems.Onyx, "o15"),
                new Development(82, 3, new int[] { 0, 6, 3, 0, 3 }, 4, Gems.Onyx, "o18"),

                //Sapphire
                new Development(83, 3, new int[] { 7, 0, 0, 0, 0 }, 4, Gems.Sapphire, "z18"),
                new Development(84, 3, new int[] { 7, 0, 0, 3, 0 }, 5, Gems.Sapphire, "z17"),
                new Development(85, 3, new int[] { 3, 3, 5, 0, 3 }, 3, Gems.Sapphire, "z15"),
                new Development(86, 3, new int[] { 6, 0, 3, 3, 0 }, 4, Gems.Sapphire, "z16"),

                //Emerald
                new Development(87, 3, new int[] { 0, 0, 0, 7, 0 }, 4, Gems.Emerald, "e18"),
                new Development(88, 3, new int[] { 0, 0, 0, 7, 3 }, 5, Gems.Emerald, "e15"),
                new Development(89, 3, new int[] { 5, 3, 3, 3, 0 }, 3, Gems.Emerald, "e16"),
                new Development(90, 3, new int[] { 3, 0, 0, 6, 3 }, 4, Gems.Emerald, "e17")

                #endregion
            };

            return l.ToList();
        }
    }
}
