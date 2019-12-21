using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class PurchaseService
    {
        private readonly Development development;
        private readonly Player player;

        public PurchaseService(Development development, Player player)
        {
            this.development = development;
            this.player = player;
        }

        private int WouldSpend(Gem gem) => Math.Max(0, development.TotalGemsOfType(gem) - player.Bonus(gem));
        private int Missing(Gem gem) => Math.Max(0, WouldSpend(gem) - player.TotalGems(gem));

        public int Cost() => Gems.GetAllGems().Sum(x => WouldSpend(x));

        public bool IsFree() => Gems.GetAllGems().All(gema => player.Bonus(gema) >= WouldSpend(gema));

        public bool CanAfford() => Gems.GetAllGems().All(gema => player.TotalGems(gema) >= WouldSpend(gema));

        /// <summary>
        /// Devuelve el oro que se gastaría al comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int OroNecesario(Player jug) => Gems.GetAllGems().Sum(gema => Math.Max(TotalCost(jug, gema) - jug.TotalGems(gema), 0));



        /// <summary>
        /// Determina si el jugador puede comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool ComprableConOro(Player jug) => OroNecesario(jug) <= jug.TotalGems(Gems.Gold);

        

        public override string ToString()
        {
            if (IsFree())
                return "You can buy it for free";

            var gastos = ListaGastosText(jug).ToList();
            if (gastos.Any())
                return string.Join("/n", new string[] { "Comprar el desarrollo gastando" }.Concat(gastos));

            return "No puedes comprar el desarrollo";
        }

        public string FaltanText(Player jug)
        {
            var faltan = ListaFaltanText(jug).ToList();
            if (faltan.Any())
                return string.Join("/n", new string[] { "No puedes comprar el desarrollo, faltan:" }.Concat(faltan));

            return "";
        }

        private IEnumerable<string> ListaGastosText(Player jug)
        {
            foreach (var gema in Gems.GetAllGems())
            {
                int gasto = Math.Min(TotalCost(jug, gema), jug.TotalGems(gema));
                if (gasto > 0)
                    yield return $"{gema.Plural(gasto)}";
            }
            int oro = OroNecesario(jug);
            if (oro > 0) yield return $"{Gems.Gold.Plural(oro)}";
        }

        private IEnumerable<string> ListaFaltanText(Player jug)
        {
            foreach (var gema in Gems.GetAllGems())
            {
                int faltan = Faltan(jug, gema);
                if (faltan > 0)
                    yield return $"{gema.Plural(faltan)}";
            }
        }
    }

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

        public override string ToString() => $"{Level.ToString()}, Bonus: {Bonus.ToString()}. {Prestige.ToString()})";

        public static bool operator ==(Development obj1, Development obj2) => obj1.Equals(obj2);
        public static bool operator !=(Development obj1, Development obj2) => !obj1.Equals(obj2);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var development = (Development)obj;
            return development.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
