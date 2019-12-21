using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class Noble : IPath
    {
        private readonly string ruta;
        public string Nombre { get; private set; }
        public int Prestigio { get; private set; }
        
        public string Path => ruta;

        private readonly int[] desarrollosRequeridos;

        public Noble(string nombre, int[] desarrollosRequeridos, int prestigio, string ruta)
        {
            Nombre = nombre;
            Prestigio = prestigio;
            this.ruta = ruta;
            this.desarrollosRequeridos = desarrollosRequeridos;
        }

        /// <summary>
        /// Devuelve cantidad de bonificación requerida
        /// </summary>
        /// <returns></returns>
        public int Requiere(Gem gema)
        {
            if (gema == Gems.Diamond) return desarrollosRequeridos[0];
            if (gema == Gems.Ruby) return desarrollosRequeridos[1];
            if (gema == Gems.Onyx) return desarrollosRequeridos[2];
            if (gema == Gems.Sapphire) return desarrollosRequeridos[3];
            if (gema == Gems.Emerald) return desarrollosRequeridos[4];
            return 0;
        }

        /// <summary>
        /// Determina si un jugador podría ser visitado por ese noble
        /// </summary>
        /// <param name="jug"></param>
        /// <returns></returns>
        public bool Visitable(Jugador jug) => Gems.GetAllGems(includeGold:false).All(gema => jug.Bonificacion(gema) >= Requiere(gema));

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
