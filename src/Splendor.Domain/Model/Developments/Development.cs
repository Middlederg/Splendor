using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class Cost
    {
        private readonly IEnumerable<Gem> gems;
        public int Total => gems.Count();

        public Cost(params Gem[] gems)
        {
            this.gems = gems.ToList();
        }

        public Cost(params IEnumerable<Gem>[] gems)
        {
            this.gems = gems.SelectMany(x => x).ToList();
        }

        public int OfType(Gem gem) => gems.Count(x => x == gem);
    }

    public class Development : IPath
    {
	    public int Id { get; private set; }
	    public Level Nivel { get; private set; }
	    public int[] Precio { get; private set; }
	    public Gem Bonificacion { get; private set; }
	    public int Prestigio { get; private set; }
        public string Path { get; }

        public Development(int id, int nivel, int[] precio, int prestigio, Gem bonificacion, string ruta)
	    {
		    Id = id;
		    Nivel = Levels.FromInt(nivel);
		    Precio = precio;
		    Prestigio = prestigio;
            Bonificacion = bonificacion;
            Path = ruta;
	    }

        public Development(Development d)
        {
            Id = d.Id;
            Nivel = d.Nivel;
            Precio = d.Precio;
            Prestigio = d.Prestigio;
            Bonificacion = d.Bonificacion;
            Path = d.Path;
        }

        /// <summary>
        /// Cantidad total de gemas que cuesta el desarrollo
        /// </summary>
        /// <returns></returns>
 	    public int TotalGemas() => Precio.Sum();

        /// <summary>
        /// Cantidad total de gemas de ese tipo que cuesta el desarrollo
        /// </summary>
        /// <returns></returns>
        public int TotalGemas(Gem gema)
        {
            if (gema == Gems.Diamond) return Precio[0];
            if (gema == Gems.Ruby) return Precio[1];
            if (gema == Gems.Onyx) return Precio[2];
            if (gema == Gems.Sapphire) return Precio[3];
            if (gema == Gems.Emerald) return Precio[4];
            return 0;
        }


        /// <summary>
        /// Número de gemas de ese tipo que gastaría el jugador al comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int Gasto(Jugador jug, Gem gema) => Math.Max(TotalGemas(gema) - jug.Bonificacion(gema), 0);

        /// <summary>
        /// Número de gemas de ese tipo que le faltan al jugador para pagar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int Faltan(Jugador jug, Gem gema) => Math.Max(0, Gasto(jug, gema) - jug.TotalGemas(gema)); 

        /// <summary>
        /// Número de gemas totales que gastaría el jugador para comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int Gasto(Jugador jug)
        {
            int coste = 0;
            foreach (var gema in Gems.GetAllGems())
                coste += Gasto(jug, gema);
            return coste;
        }

        /// <summary>
        /// Determina si el jugador puede comprar el desarrollo sin gastar comodines de oro
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool ComprableSinoro(Jugador jug) => Gems.GetAllGems().All(gema => jug.TotalGemas(gema) >= Gasto(jug, gema));

        /// <summary>
        /// Devuelve el oro que se gastaría al comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int OroNecesario(Jugador jug) => Gems.GetAllGems().Sum(gema => Math.Max(Gasto(jug, gema) - jug.TotalGemas(gema), 0));

        ///// <summary>
        ///// Devuelve el oro que se gastaría al comprar el desarrollo
        ///// Sustituido por el metodo anterior, parece mas bonito
        ///// </summary>
        ///// <param name="jug"></param>
        ///// <returns></returns>
        //public int OroNecesario(Jugador jug) 
        //{
        //    int coste = 0;
        //    //Negocio.GameHelper.ObtenerListaGemas().ToList().ForEach(gema => coste += Math.Max(Gasto(jug, gema) - jug.TotalGemas(gema),0));
        //    return coste;
        //}

        /// <summary>
        /// Determina si el jugador puede comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool ComprableConOro(Jugador jug) => OroNecesario(jug) <= jug.TotalGemas(Gems.Gold);

        /// <summary>
        /// Determina si el jugador es capaz de comprar el desarrollo sin gastar gemas
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool Gratuito(Jugador jug) => Gems.GetAllGems().All(gema => jug.Bonificacion(gema) >= TotalGemas(gema));

        public string GastoText(Jugador jug)
        {
            if (Gratuito(jug))
                return "Comprar el desarrollo sin gastar gemas";

            var gastos = ListaGastosText(jug).ToList();
            if (gastos.Any())
                return string.Join("/n", new string[] { "Comprar el desarrollo gastando" }.Concat(gastos));

            return "No puedes comprar el desarrollo";
        }

        public string FaltanText(Jugador jug)
        {
            var faltan = ListaFaltanText(jug).ToList();
            if (faltan.Any())
                return string.Join("/n", new string[] { "No puedes comprar el desarrollo, faltan:" }.Concat(faltan));

            return "";
        }

        private IEnumerable<string> ListaGastosText(Jugador jug)
        {
            foreach (var gema in Gems.GetAllGems())
            {
                int gasto = Math.Min(Gasto(jug, gema), jug.TotalGemas(gema));
                if (gasto > 0)
                    yield return $"{gema.Plural(gasto)}";
            }
            int oro = OroNecesario(jug);
            if (oro > 0) yield return $"{Gems.Gold.Plural(oro)}";
        }

        private IEnumerable<string> ListaFaltanText(Jugador jug)
        {
            foreach (var gema in Gems.GetAllGems())
            {
                int faltan = Faltan(jug, gema);
                if (faltan > 0)
                    yield return $"{gema.Plural(faltan)}";
            }
        }

        public override string ToString() => $"Desarrollo de nivel {Nivel.LevelNumber} ({Prestigio} punto{(Prestigio == 1 ? "" : "s")})";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                throw new ArgumentException("Para comparar dos instancias de " + GetType() + " deben ser del mismo tipo");
            return ((Development)obj).Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();

        public Development Copiar() => new Development(this);
    }
}
