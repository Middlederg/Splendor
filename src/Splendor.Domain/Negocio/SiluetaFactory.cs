using System.Collections.Generic;

namespace Splendor.Domain
{
    public static class SiluetaFactory
    {
        public static Silueta Amanda => new Silueta(1, "Amanda");
        public static Silueta Grace => new Silueta(2, "Grace");
        public static Silueta Frankie => new Silueta(3, "Frankie");
        public static Silueta Debra => new Silueta(4, "Debra");
        public static Silueta Michael => new Silueta(5, "Michael");
        public static Silueta Goor => new Silueta(6, "Goor");
        public static Silueta Dragan => new Silueta(7, "Dragan");
        public static Silueta Jakob => new Silueta(8, "Jakob");
        public static Silueta Nilsen => new Silueta(9, "Nilsen");
        public static Silueta Danilo => new Silueta(10, "Danilo");
        public static Silueta Brenda => new Silueta(11, "Brenda");
        public static Silueta Donnie => new Silueta(12, "Donnie");
        public static Silueta Michelle => new Silueta(13, "Michelle");
        public static Silueta Denver => new Silueta(14, "Denver");
        public static Silueta Pietro => new Silueta(15, "Pietro");
        public static Silueta Robinson => new Silueta(16, "Robinson");

        public static IEnumerable<Silueta> Siluetas
        => new List<Silueta>() { Amanda, Grace, Frankie, Debra, Michael, Goor, Dragan, Jakob, Nilsen, Danilo, Brenda, Donnie, Michelle, Denver, Pietro, Robinson };
    }

    
}
