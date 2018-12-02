using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splendor.Core.Enumeraciones;
using Splendor.Core.Negocio;

namespace Splendor.Core.Model
{
    public class Jugador
    {
	    public int Id { get; private set; }
	    public Silueta Silueta { get; private set; }
	    public List<Gema> Gemas { get; set; }
        public List<Noble> NoblesVisitados { get; set; }
	    public List<Desarrollo> Desarrollos { get; set; }
	    public List<Desarrollo> Reservadas { get; set; }
        public int TurnosJugados { get; set; }

        public string Nombre => Silueta.Nombre;

	    public Jugador(int id, Silueta silueta)
	    {
		    Id = id;
            Silueta = silueta;
            Reset();
	    }

	    public void Reset()
	    {
		    Gemas = new List<Gema>();
		    NoblesVisitados = new List<Noble>();
		    Desarrollos = new List<Desarrollo>();
		    Reservadas = new List<Desarrollo>();
            TurnosJugados = 0;
	    }

        /// <summary>
        /// Puntuación del jugador
        /// </summary>
        /// <returns></returns>
        public int Prestigio() => NoblesVisitados.Sum(x => x.Prestigio) + Desarrollos.Sum(x => x.Prestigio);

        /// <summary>
        /// Cantidad total de gemas que tiene el jugador
        /// </summary>
        /// <returns></returns>
 	    public int TotalGemas() => Gemas.Count();

        /// <summary>
        /// Cantidad total de gemas de ese tipo que tiene el jugador
        /// </summary>
        /// <returns></returns>
        public int TotalGemas(Gema g) => Gemas.Count(x => x.Equals(g));

        /// <summary>
        /// Devuelve número de bonificaciones que proveen los desarrollos para un tipo de gema
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public int Bonificacion(Gema gema) => Desarrollos.Count(x => x.Bonificacion.Equals(gema));        

        /// <summary>
        /// Devuelve poder aquisitivo en un tipo de gema
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public int Poder(Gema gema) => TotalGemas(gema) + Bonificacion(gema);

        /// <summary>
        /// Determina si el jugador puede reservar un desarrollo
        /// (Máximo: 3)
        /// </summary>
        /// <returns></returns>
        public bool PuedeReservar() => Reservadas.Count < 3;

        /// <summary>
        /// Indica si el jugador debe descartar gemas hasta tener diez
        /// </summary>
        public bool DebeDevolverGemas() => Gemas.Count > 10;

        /// <summary>
        /// Jugador compra el desarrollo. Devuelve lista de monedas usadas
        /// </summary>
        /// <param name="des">Desarrollo</param>
        /// <returns></returns>
        public IEnumerable<Gema> Comprar(Desarrollo des)
        {
            if (!des.ComprableConOro(this))
                throw new Exception($"El jugador {ToString()} no puede comprar {des.ToString()}");

            List<Gema> monedas = new List<Gema>();

            //Quitamos el oro y lo añadimos a la lista
            foreach (int i in Enumerable.Range(0, des.OroNecesario(this)))
            {
                monedas.Add(Gema.Oro);
                Gemas.Remove(Gema.Oro);
            }

            //Quitamos las gemas y las añadimos a la lista
            GemasFactory.GetListaGemas()
            .ToList()
            .ForEach(gema => 
            {
                foreach (int i in Enumerable.Range(0, des.Gasto(this, gema)))
                {
                    monedas.Add(gema);
                    Gemas.Remove(gema);
                };
            });
            Desarrollos.Add(des);
            return monedas;
        }

        /// <summary>
        /// Devuelve un desarrollo si hubiera alguno que hiciera al jugador obtener una victoria segura
        /// </summary>
        /// <param name="desarrollos"></param>
        /// <param name="puntuacionObjetivo"></param>
        /// <returns></returns>
        public Desarrollo VictoriaSegura(IEnumerable<Desarrollo> desarrollos, int puntuacionObjetivo = 15)
        => desarrollos.Where(x => x.ComprableConOro(this)).FirstOrDefault(d => d.Prestigio + Prestigio() >= puntuacionObjetivo);

        /// <summary>
        /// Devuelve el desarrollo que le salga más barato de una lista propuesta
        /// 1 Menos oro
        /// 2 Menor número de gemas
        /// </summary>
        /// <param name="desarrollos"></param>
        /// <returns></returns>
        public Desarrollo MejorDesarrollo(IEnumerable<Desarrollo> desarrollos) => MejoresDesarrollo(desarrollos).FirstOrDefault();
        
        /// <summary>
        /// Devuelve los desarrollos más baratos de una lista propuesta
        /// 1 Menos oro
        /// 2 Menor número de gemas
        /// </summary>
        /// <param name="desarrollos"></param>
        /// <returns></returns>
        public IEnumerable<Desarrollo> MejoresDesarrollo(IEnumerable<Desarrollo> desarrollos)
        {
            int menorOro = desarrollos.Min(x => x.OroNecesario(this)); //menor oro gastable
            return desarrollos.OrderBy(x => x.OroNecesario(this).Equals(menorOro)).ThenBy(x => x.Gasto(this));
        }

        public override string ToString() => $"{Silueta.Nombre} ({Prestigio()} punto{(Prestigio() != 1 ? "s" : "")})";
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                throw new ArgumentException("Para comparar dos instancias de " + GetType() + " deben ser del mismo tipo");
            return ((Jugador)obj).Id == Id;
        }
        public override int GetHashCode() => Id.GetHashCode();
    }
}
