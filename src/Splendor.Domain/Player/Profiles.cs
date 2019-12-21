using System.Collections.Generic;

namespace Splendor.Domain
{
    public static class Profiles
    {
        public static Profile Amanda => new Profile(1, "Amanda");
        public static Profile Grace => new Profile(2, "Grace");
        public static Profile Frankie => new Profile(3, "Frankie");
        public static Profile Debra => new Profile(4, "Debra");
        public static Profile Michael => new Profile(5, "Michael");
        public static Profile Goor => new Profile(6, "Goor");
        public static Profile Dragan => new Profile(7, "Dragan");
        public static Profile Jakob => new Profile(8, "Jakob");
        public static Profile Nilsen => new Profile(9, "Nilsen");
        public static Profile Danilo => new Profile(10, "Danilo");
        public static Profile Brenda => new Profile(11, "Brenda");
        public static Profile Donnie => new Profile(12, "Donnie");
        public static Profile Michelle => new Profile(13, "Michelle");
        public static Profile Denver => new Profile(14, "Denver");
        public static Profile Pietro => new Profile(15, "Pietro");
        public static Profile Robinson => new Profile(16, "Robinson");

        public static IEnumerable<Profile> Siluetas
        {
            get
            {
                return new List<Profile>() { Amanda, Grace, Frankie, Debra, Michael, Goor, Dragan, Jakob, Nilsen, Danilo, Brenda, Donnie, Michelle, Denver, Pietro, Robinson };
            }
        }
    }

    
}
