using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splendor.Core.Enumeraciones;
using Splendor.Core.Negocio;

namespace Splendor.Core.Model
{
    public class Desarrollo
    {
	    public int Id { get; private set; }
	    public NivelDesarrollo Nivel { get; private set; }
	    public int[] Precio { get; private set; }
	    public Gema Bonificacion { get; private set; }
	    public int Prestigio { get; private set; }
	    public string Ruta { get; private set; }

	    public Desarrollo(int id, int nivel, int[] precio, int prestigio, Gema bonificacion, string ruta)
	    {
		    Id = id;
		    Nivel = (NivelDesarrollo)nivel;
		    Precio = precio;
		    Prestigio = prestigio;
            Bonificacion = bonificacion;
            Ruta = ruta;
	    }

        public Desarrollo(Desarrollo d)
        {
            Id = d.Id;
            Nivel = d.Nivel;
            Precio = d.Precio;
            Prestigio = d.Prestigio;
            Bonificacion = d.Bonificacion;
            Ruta = d.Ruta;
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
        public int TotalGemas(Gema g) => Precio[((int)g) - 1];

        /// <summary>
        /// Número de gemas de ese tipo que gastaría el jugador al comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int Gasto(Jugador jug, Gema gema) => Math.Max(TotalGemas(gema) - jug.Bonificacion(gema), 0);

        /// <summary>
        /// Número de gemas de ese tipo que le faltan al jugador para pagar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int Faltan(Jugador jug, Gema gema) => Math.Max(0, Gasto(jug, gema) - jug.TotalGemas(gema)); 

        /// <summary>
        /// Número de gemas totales que gastaría el jugador para comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int Gasto(Jugador jug)
        {
            int coste = 0;
            foreach (var gema in GemasFactory.GetListaGemas())
                coste += Gasto(jug, gema);
            return coste;
        }

        /// <summary>
        /// Determina si el jugador puede comprar el desarrollo sin gastar comodines de oro
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool ComprableSinoro(Jugador jug) => GemasFactory.GetListaGemas().All(gema => jug.TotalGemas(gema) >= Gasto(jug, gema));

        /// <summary>
        /// Devuelve el oro que se gastaría al comprar el desarrollo
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public int OroNecesario(Jugador jug) => GemasFactory.GetListaGemas().Sum(gema => Math.Max(Gasto(jug, gema) - jug.TotalGemas(gema), 0));

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
        public bool ComprableConOro(Jugador jug) => OroNecesario(jug) <= jug.TotalGemas(Gema.Oro);

        /// <summary>
        /// Determina si el jugador es capaz de comprar el desarrollo sin gastar gemas
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool Gratuito(Jugador jug) => GemasFactory.GetListaGemas().All(gema => jug.Bonificacion(gema) >= TotalGemas(gema));

        public string GastoText(Jugador jug)
        {
            if (Gratuito(jug))
                return "Comprar el desarrollo sin gastar gemas";

            var gastos = ListaGastosText(jug).ToList();
            if (gastos.Any())
                return new string[] { "Comprar el desarrollo gastando" }.Concat(gastos).ListaConFilas();

            return "No puedes comprar el desarrollo";
        }

        public string FaltanText(Jugador jug)
        {
            var faltan = ListaFaltanText(jug).ToList();
            if (faltan.Any())
                return new string[] { "No puedes comprar el desarrollo, faltan:" }.Concat(faltan).ListaConFilas();

            return "";
        }

        private IEnumerable<string> ListaGastosText(Jugador jug)
        {
            foreach (var gema in GemasFactory.GetListaGemas())
            {
                int gasto = Math.Min(Gasto(jug, gema), jug.TotalGemas(gema));
                if (gasto > 0)
                    yield return $"{gema.Plural(gasto)}";
            }
            int oro = OroNecesario(jug);
            if (oro > 0) yield return $"{Gema.Oro.Plural(oro)}";
        }

        private IEnumerable<string> ListaFaltanText(Jugador jug)
        {
            foreach (var gema in GemasFactory.GetListaGemas())
            {
                int faltan = Faltan(jug, gema);
                if (faltan > 0)
                    yield return $"{gema.Plural(faltan)}";
            }
        }

        public override string ToString() => $"Desarrollo de nivel {(int)Nivel} ({Prestigio} punto{(Prestigio == 1 ? "" : "s")})";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                throw new ArgumentException("Para comparar dos instancias de " + GetType() + " deben ser del mismo tipo");
            return ((Desarrollo)obj).Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();

        public Desarrollo Copiar() => new Desarrollo(this);
    }
}
