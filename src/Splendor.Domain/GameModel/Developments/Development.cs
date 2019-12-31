using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class Development : IPath
    {
	    public int Id { get; }
	    public Level Level { get; }
        public Gem Bonus { get; }

        public Prestige Prestige { get; }
        public string Path { get; }

        private readonly Cost price;
        public int TotalGems() => price.Total;
        public int TotalGemsOfType(Gem gem) => price.OfType(gem);

        public Development(int id, Level level, int prestige, Gem bonificacion, string ruta, params IEnumerable<Gem>[] prices)
	    {
            if (prestige < 0)
                throw new ArgumentOutOfRangeException(nameof(prestige), "Prestige should be a value grater than 0");

		    Id = id;
		    Level = level;
		    Prestige = (Prestige)prestige;
            Bonus = bonificacion ?? throw new ArgumentNullException(nameof(bonificacion));
            Path = ruta;

            price = new Cost(prices);

        }

        public override string ToString()
        {
            string prestigeText = Prestige > 0 ? $" ({Prestige.ToString()})" : "";
            switch (Constants.CurrentLanguage)
            {
                case Language.Spanish:
                    return $"Desarrollo de {Bonus.ToString()} de {Level.ToString()}{prestigeText}";
                default:
                    return $"{Bonus.ToString()} {Level.ToString()} development{prestigeText}";
            }
        }

        public string ToStringWithPrice() => $"{ToString()} ({price.ToString()})";

        public static bool operator ==(Development obj1, Development obj2)
        {
            if (obj1 == null) return obj2 == null;
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Development obj1, Development obj2)
        {
            if (obj1 == null) return obj2 != null;
            return !obj1.Equals(obj2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var development = (Development)obj;
            return development.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();

        public static string Singular()
        {
            switch (Constants.CurrentLanguage)
            {
                case Language.Spanish: return "desarrollo";
                default: return "development";
            }
        }

        public static string Plural()
        {
            switch (Constants.CurrentLanguage)
            {
                case Language.Spanish: return "desarrollos";
                default: return "developments";
            }
        }
    }
}
