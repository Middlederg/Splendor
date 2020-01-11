using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class Noble : IPath
    {
        private readonly string name;
        public Prestige Prestige { get; }
        public string Path { get; }

        private readonly Cost requierements;

        public Noble(string name, int prestige, string path, params IEnumerable<Gem>[] requirements)
        {
            this.name = name;
            Prestige = (Prestige)prestige;
            Path = path;
            requierements = new Cost(requirements);
        }

        public int RequiredQuantity(Gem gema) => requierements.OfType(gema);

	    public override string ToString() => name;
        public string ToStringDetailed() => $"{name} ({requierements.ToString()})";

        public static bool operator ==(Noble noble1, Noble noble2) => noble1.Equals(noble2);
        public static bool operator !=(Noble noble1, Noble noble2) => !noble1.Equals(noble2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var noble = (Noble)obj;
            return noble.name.Equals(name);
        }

        public override int GetHashCode() => name.GetHashCode();
    }
}
