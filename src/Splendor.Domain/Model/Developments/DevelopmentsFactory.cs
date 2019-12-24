using System.Collections.Generic;
using System.Linq;
using System;

namespace Splendor.Domain
{
    public static class DevelopmentsFactory
    {
        public static IEnumerable<Development> GetDeck() => AllDevelopments().ToList().RandomizeList();

        private static IEnumerable<Development> AllDevelopments()
        {
            return FirstLevel((Level)1)
                .Concat(SecondLevel((Level)2))
                .Concat(ThirdLevel((Level)3));
        }

        private static IEnumerable<Development> FirstLevel(Level level)
        {
            //Diamond
            yield return new Development(1, level, 0, Gems.Diamond, "d7", Gems.Onyx.Get(2), Gems.Sapphire.Get(2));
            yield return new Development(2, level, 0, Gems.Diamond, "d3", Gems.Diamond.Get(3), Gems.Onyx.Get(1), Gems.Sapphire.Get(1));
            yield return new Development(3, level, 0, Gems.Diamond, "d2", Gems.Onyx.Get(1), Gems.Sapphire.Get(2), Gems.Emerald.Get(2));
            yield return new Development(4, level, 0, Gems.Diamond, "d4", Gems.Ruby.Get(1), Gems.Onyx.Get(1), Gems.Sapphire.Get(1), Gems.Emerald.Get(1));
            yield return new Development(5, level, 1, Gems.Diamond, "d5", Gems.Emerald.Get(4));
            yield return new Development(6, level, 0, Gems.Diamond, "d6", Gems.Ruby.Get(2), Gems.Onyx.Get(1));
            yield return new Development(7, level, 0, Gems.Diamond, "d1", Gems.Ruby.Get(1), Gems.Onyx.Get(1), Gems.Sapphire.Get(1), Gems.Emerald.Get(2));
            yield return new Development(8, level, 0, Gems.Diamond, "d8", Gems.Sapphire.Get(3));

            //Ruby
            yield return new Development(9, level, 0, Gems.Ruby, "r3", Gems.Diamond.Get(2), Gems.Ruby.Get(2));
            yield return new Development(10, level, 0, Gems.Ruby, "r6", Gems.Diamond.Get(1), Gems.Ruby.Get(1), Gems.Onyx.Get(3));
            yield return new Development(11, level, 0, Gems.Ruby, "r7", Gems.Diamond.Get(2), Gems.Onyx.Get(2), Gems.Emerald.Get(1));
            yield return new Development(12, level, 0, Gems.Ruby, "r5", Gems.Diamond.Get(1), Gems.Onyx.Get(1), Gems.Sapphire.Get(1), Gems.Emerald.Get(1));
            yield return new Development(13, level, 1, Gems.Ruby, "r4", Gems.Diamond.Get(4));
            yield return new Development(14, level, 0, Gems.Ruby, "r1", Gems.Sapphire.Get(2), Gems.Emerald.Get(1));
            yield return new Development(15, level, 0, Gems.Ruby, "r8", Gems.Diamond.Get(1), Gems.Onyx.Get(1), Gems.Sapphire.Get(1), Gems.Emerald.Get(2));
            yield return new Development(16, level, 0, Gems.Ruby, "r2", Gems.Diamond.Get(3));

            //Onyx
            yield return new Development(17, level, 0, Gems.Onyx, "o3", Gems.Diamond.Get(2), Gems.Emerald.Get(2));
            yield return new Development(18, level, 0, Gems.Onyx, "o8", Gems.Ruby.Get(2), Gems.Onyx.Get(1), Gems.Emerald.Get(1));
            yield return new Development(19, level, 0, Gems.Onyx, "o7", Gems.Diamond.Get(2), Gems.Ruby.Get(1), Gems.Sapphire.Get(2));
            yield return new Development(20, level, 0, Gems.Onyx, "o5", Gems.Diamond.Get(1), Gems.Ruby.Get(1), Gems.Sapphire.Get(1), Gems.Emerald.Get(1));
            yield return new Development(21, level, 1, Gems.Onyx, "o4", Gems.Sapphire.Get(4));
            yield return new Development(22, level, 0, Gems.Onyx, "o1", Gems.Ruby.Get(1), Gems.Emerald.Get(2));
            yield return new Development(23, level, 0, Gems.Onyx, "o6", Gems.Diamond.Get(1), Gems.Ruby.Get(1), Gems.Sapphire.Get(2), Gems.Emerald.Get(1));
            yield return new Development(24, level, 0, Gems.Onyx, "o2", Gems.Emerald.Get(3));

            //Sapphire
            yield return new Development(25, level, 0, Gems.Sapphire, "z5", Gems.Sapphire.Get(2), Gems.Emerald.Get(2));
            yield return new Development(26, level, 0, Gems.Sapphire, "z7", Gems.Ruby.Get(1), Gems.Sapphire.Get(1), Gems.Emerald.Get(3));
            yield return new Development(27, level, 0, Gems.Sapphire, "z1", Gems.Diamond.Get(1), Gems.Ruby.Get(2), Gems.Emerald.Get(2));
            yield return new Development(28, level, 0, Gems.Sapphire, "z4", Gems.Diamond.Get(1), Gems.Ruby.Get(1), Gems.Onyx.Get(1), Gems.Emerald.Get(1));
            yield return new Development(29, level, 1, Gems.Sapphire, "z6", Gems.Ruby.Get(4));
            yield return new Development(30, level, 0, Gems.Sapphire, "z3", Gems.Diamond.Get(1), Gems.Onyx.Get(2));
            yield return new Development(31, level, 0, Gems.Sapphire, "z8", Gems.Diamond.Get(1), Gems.Ruby.Get(2), Gems.Onyx.Get(1), Gems.Emerald.Get(1));
            yield return new Development(32, level, 0, Gems.Sapphire, "z2", Gems.Onyx.Get(3));

            //Emerald
            yield return new Development(33, level, 0, Gems.Emerald, "e4", Gems.Ruby.Get(2), Gems.Sapphire.Get(2));
            yield return new Development(34, level, 0, Gems.Emerald, "e8", Gems.Diamond.Get(1), Gems.Sapphire.Get(3), Gems.Emerald.Get(1));
            yield return new Development(35, level, 0, Gems.Emerald, "e6", Gems.Ruby.Get(2), Gems.Onyx.Get(2), Gems.Sapphire.Get(1));
            yield return new Development(36, level, 0, Gems.Emerald, "e3", Gems.Diamond.Get(1), Gems.Ruby.Get(1), Gems.Onyx.Get(1), Gems.Sapphire.Get(1));
            yield return new Development(37, level, 1, Gems.Emerald, "e5", Gems.Onyx.Get(4));
            yield return new Development(38, level, 0, Gems.Emerald, "e2", Gems.Diamond.Get(2), Gems.Sapphire.Get(1));
            yield return new Development(39, level, 0, Gems.Emerald, "e7", Gems.Diamond.Get(1), Gems.Ruby.Get(1), Gems.Onyx.Get(2), Gems.Sapphire.Get(1));
            yield return new Development(40, level, 0, Gems.Emerald, "e1", Gems.Ruby.Get(3));
        }

        private static IEnumerable<Development> SecondLevel(Level level)
        {
            //Diamond
            yield return new Development(41, level, 2, Gems.Diamond, "d9", Gems.Ruby.Get(5));
            yield return new Development(42, level, 3, Gems.Diamond, "d10", Gems.Diamond.Get(6));
            yield return new Development(43, level, 1, Gems.Diamond, "d11", Gems.Ruby.Get(2), Gems.Onyx.Get(2), Gems.Emerald.Get(3));
            yield return new Development(44, level, 2, Gems.Diamond, "d12", Gems.Ruby.Get(4), Gems.Onyx.Get(2), Gems.Emerald.Get(1));
            yield return new Development(45, level, 1, Gems.Diamond, "d13", Gems.Diamond.Get(2), Gems.Ruby.Get(3), Gems.Sapphire.Get(3));
            yield return new Development(46, level, 2, Gems.Diamond, "d14", Gems.Ruby.Get(5), Gems.Onyx.Get(3));

            //Rubí
            yield return new Development(47, level, 1, Gems.Ruby, "r9", Gems.Ruby.Get(2), Gems.Onyx.Get(2), Gems.Sapphire.Get(3));
            yield return new Development(48, level, 2, Gems.Ruby, "r10", Gems.Ruby.Get(2), Gems.Onyx.Get(2), Gems.Sapphire.Get(3));
            yield return new Development(49, level, 1, Gems.Ruby, "r11", Gems.Diamond.Get(2), Gems.Ruby.Get(2), Gems.Onyx.Get(3));
            yield return new Development(50, level, 3, Gems.Ruby, "r12", Gems.Ruby.Get(6));
            yield return new Development(51, level, 2, Gems.Ruby, "r13", Gems.Diamond.Get(1), Gems.Sapphire.Get(4), Gems.Emerald.Get(2));
            yield return new Development(52, level, 2, Gems.Ruby, "r14", Gems.Onyx.Get(5));

            //Onyx
            yield return new Development(53, level, 1, Gems.Onyx, "o9", Gems.Diamond.Get(3), Gems.Onyx.Get(2), Gems.Emerald.Get(3));
            yield return new Development(54, level, 2, Gems.Onyx, "o10", Gems.Ruby.Get(3), Gems.Emerald.Get(5));
            yield return new Development(55, level, 2, Gems.Onyx, "o11", Gems.Diamond.Get(5));
            yield return new Development(56, level, 3, Gems.Onyx, "o12", Gems.Onyx.Get(6));
            yield return new Development(57, level, 1, Gems.Onyx, "o13", Gems.Diamond.Get(3), Gems.Sapphire.Get(2), Gems.Emerald.Get(2));
            yield return new Development(58, level, 2, Gems.Onyx, "o14", Gems.Ruby.Get(2), Gems.Sapphire.Get(1), Gems.Emerald.Get(4));

            //Sapphire
            yield return new Development(59, level, 3, Gems.Sapphire, "z9", Gems.Sapphire.Get(6));
            yield return new Development(60, level, 2, Gems.Sapphire, "z10", Gems.Diamond.Get(2), Gems.Ruby.Get(1), Gems.Onyx.Get(4));
            yield return new Development(61, level, 2, Gems.Sapphire, "z11", Gems.Sapphire.Get(5));
            yield return new Development(62, level, 1, Gems.Sapphire, "z12", Gems.Onyx.Get(3), Gems.Sapphire.Get(2), Gems.Emerald.Get(3));
            yield return new Development(63, level, 2, Gems.Sapphire, "z13", Gems.Diamond.Get(5), Gems.Sapphire.Get(2));
            yield return new Development(64, level, 1, Gems.Sapphire, "z14", Gems.Ruby.Get(3), Gems.Sapphire.Get(2), Gems.Emerald.Get(2));

            //Emerald
            yield return new Development(65, level, 3, Gems.Emerald, "e9", Gems.Emerald.Get(6));
            yield return new Development(66, level, 2, Gems.Emerald, "e10", Gems.Diamond.Get(4), Gems.Onyx.Get(1), Gems.Sapphire.Get(2));
            yield return new Development(67, level, 2, Gems.Emerald, "e11", Gems.Emerald.Get(5));
            yield return new Development(68, level, 2, Gems.Emerald, "e12", Gems.Sapphire.Get(5), Gems.Emerald.Get(3));
            yield return new Development(69, level, 1, Gems.Emerald, "e13", Gems.Diamond.Get(3), Gems.Ruby.Get(3), Gems.Emerald.Get(2));
            yield return new Development(70, level, 1, Gems.Emerald, "e14", Gems.Diamond.Get(2), Gems.Onyx.Get(2), Gems.Sapphire.Get(3));
        }

        private static IEnumerable<Development> ThirdLevel(Level level)
        {
            //Diamond
            yield return new Development(71, level, 4, Gems.Diamond, "d15", Gems.Onyx.Get(7));
            yield return new Development(72, level, 5, Gems.Diamond, "d16", Gems.Diamond.Get(3), Gems.Onyx.Get(7));
            yield return new Development(73, level, 3, Gems.Diamond, "d17", Gems.Ruby.Get(5), Gems.Onyx.Get(3), Gems.Sapphire.Get(3), Gems.Emerald.Get(3));
            yield return new Development(74, level, 4, Gems.Diamond, "d18", Gems.Diamond.Get(3), Gems.Ruby.Get(3), Gems.Onyx.Get(6));

            //Rubí
            yield return new Development(75, level, 3, Gems.Ruby, "r16", Gems.Diamond.Get(3), Gems.Onyx.Get(3), Gems.Sapphire.Get(5), Gems.Emerald.Get(3));
            yield return new Development(76, level, 5, Gems.Ruby, "r15", Gems.Ruby.Get(3), Gems.Emerald.Get(7));
            yield return new Development(77, level, 4, Gems.Ruby, "r18", Gems.Emerald.Get(7));
            yield return new Development(78, level, 4, Gems.Ruby, "r17", Gems.Ruby.Get(3), Gems.Sapphire.Get(3), Gems.Emerald.Get(6));

            //Onyx
            yield return new Development(79, level, 4, Gems.Onyx, "o16", Gems.Ruby.Get(7));
            yield return new Development(80, level, 5, Gems.Onyx, "o17", Gems.Ruby.Get(7), Gems.Onyx.Get(3));
            yield return new Development(81, level, 3, Gems.Onyx, "o15", Gems.Diamond.Get(3), Gems.Ruby.Get(3), Gems.Sapphire.Get(3), Gems.Emerald.Get(5));
            yield return new Development(82, level, 4, Gems.Onyx, "o18", Gems.Ruby.Get(6), Gems.Onyx.Get(3), Gems.Emerald.Get(3));

            //Sapphire
            yield return new Development(83, level, 4, Gems.Sapphire, "z18", Gems.Diamond.Get(7));
            yield return new Development(84, level, 5, Gems.Sapphire, "z17", Gems.Diamond.Get(7), Gems.Sapphire.Get(3));
            yield return new Development(85, level, 3, Gems.Sapphire, "z15", Gems.Diamond.Get(3), Gems.Ruby.Get(3), Gems.Sapphire.Get(5), Gems.Emerald.Get(3));
            yield return new Development(86, level, 4, Gems.Sapphire, "z16", Gems.Diamond.Get(6), Gems.Sapphire.Get(3), Gems.Onyx.Get(3));

            //Emerald
            yield return new Development(87, level, 4, Gems.Emerald, "e18", Gems.Sapphire.Get(7));
            yield return new Development(88, level, 5, Gems.Emerald, "e15", Gems.Sapphire.Get(7), Gems.Emerald.Get(3));
            yield return new Development(89, level, 3, Gems.Emerald, "e16", Gems.Diamond.Get(5), Gems.Ruby.Get(3), Gems.Onyx.Get(3), Gems.Sapphire.Get(3));
            yield return new Development(90, level, 4, Gems.Emerald, "e17", Gems.Diamond.Get(3), Gems.Sapphire.Get(6), Gems.Emerald.Get(3));
        }
    }
}
