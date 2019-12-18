using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splendor.Core.Enumeraciones;

namespace Splendor.Core.Model
{
    public class Noble
    {
        public string Nombre { get; private set; }
        public int Prestigio { get; private set; }
        public string Ruta { get; private set; }

        private readonly int[] desarrollosRequeridos;

        public Noble(string nombre, int[] desarrollosRequeridos, int prestigio, string ruta)
        {
            Nombre = nombre;
            Prestigio = prestigio;
            Ruta = ruta;
            this.desarrollosRequeridos = desarrollosRequeridos;
        }

        /// <summary>
        /// Devuelve cantidad de bonificación requerida
        /// </summary>
        /// <returns></returns>
        public int Requiere(Gema gema) => desarrollosRequeridos[(int)gema - 1];

        /// <summary>
        /// Determina si un jugador podría ser visitado por ese noble
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool Visitable(Jugador jug) => Negocio.GemasFactory.GetListaGemas().All(gema => jug.Bonificacion(gema) >= Requiere(gema));

	    public override string ToString() => $"{Nombre} ({Prestigio} puntos)";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                throw new ArgumentException("Para comparar dos instancias de " + GetType() + " deben ser del mismo tipo");
            return ((Noble)obj).Nombre.Equals(Nombre);
        }

        public override int GetHashCode() => Nombre.GetHashCode();
    }
}
