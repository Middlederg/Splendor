using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public static class Avatars
    {
        public static Avatar Amanda => new Avatar(1, "Amanda");
        public static Avatar Grace => new Avatar(2, "Grace");
        public static Avatar Frankie => new Avatar(3, "Frankie");
        public static Avatar Debra => new Avatar(4, "Debra");
        public static Avatar Michael => new Avatar(5, "Michael");
        public static Avatar Goor => new Avatar(6, "Goor");
        public static Avatar Dragan => new Avatar(7, "Dragan");
        public static Avatar Jakob => new Avatar(8, "Jakob");
        public static Avatar Nilsen => new Avatar(9, "Nilsen");
        public static Avatar Danilo => new Avatar(10, "Danilo");
        public static Avatar Brenda => new Avatar(11, "Brenda");
        public static Avatar Donnie => new Avatar(12, "Donnie");
        public static Avatar Michelle => new Avatar(13, "Michelle");
        public static Avatar Denver => new Avatar(14, "Denver");
        public static Avatar Pietro => new Avatar(15, "Pietro");
        public static Avatar Robinson => new Avatar(16, "Robinson");

        public static IEnumerable<Avatar> GetAll() 
            => new List<Avatar>() { Amanda, Grace, Frankie, Debra, Michael, Goor, Dragan, Jakob, Nilsen, Danilo, Brenda, Donnie, Michelle, Denver, Pietro, Robinson };

        public static Avatar GetById(int id) => GetAll().FirstOrDefault(x => x.Id == id);
        public static Avatar GetRandomAvatar() => GetAll().GetRandomItem();
    }

    
}
