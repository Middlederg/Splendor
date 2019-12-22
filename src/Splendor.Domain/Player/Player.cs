using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{

    public class Player
    {
	    public int Id { get; }
	    public Profile Profile { get; }

	    public List<Gem> Gems { get; }
        public void AddGem(Gem gem) => Gems.Add(gem);
        public int TotalGems() => Gems.Count();
        public int TotalGems(Gem gem) => Gems.Count(x => x == gem);
        public void TakeGems(params Gem[] gems)
        {
            foreach (var gem in gems)
            {
                var taken = Gems.Remove(gem);
                if (!taken)
                    throw new NotFoundException(nameof(Gem));
            }
        }

        public List<Noble> VisitedNobles { get; }
        public void AddNoble(Noble noble) => VisitedNobles.Add(noble);

        public List<Development> Developments { get; }
        public void BuyCard(Development development) => Developments.Add(development);

	    public List<Development> ReservedDevelopments { get; }
        public void ReserveCard(Development development) => ReservedDevelopments.Add(development);

        public List<Move> Moves { get; }

        public string Nombre => Profile.ToString();

        public int Prestige => VisitedNobles.Sum(x => x.Prestige) + Developments.Sum(x => x.Prestige);

        public Player(int id, Profile profile)
	    {
		    Id = id;
            Profile = profile;
            Gems = new List<Gem>();
            VisitedNobles = new List<Noble>();
            Developments = new List<Development>();
            ReservedDevelopments = new List<Development>();

            Moves = new List<Move>();
        }

        public Player Reset() => new Player(Id, Profile);

        public int Bonus(Gem gem) => Developments.Count(x => x.Bonus == gem);
        public int PurchasingPower(Gem gema) => TotalGems(gema) + Bonus(gema);


        //public IEnumerable<Gem> Comprar(Development des)
        //{
        //    if (!des.ComprableConOro(this))
        //        throw new Exception($"El jugador {ToString()} no puede comprar {des.ToString()}");

        //    List<Gem> monedas = new List<Gem>();

        //    //Quitamos el oro y lo añadimos a la lista
        //    foreach (int i in Enumerable.Range(0, des.OroNecesario(this)))
        //    {
        //        monedas.Add(Gems.Gold);
        //        Gemas.Remove(Gems.Gold);
        //    }

        //    //Quitamos las gemas y las añadimos a la lista
        //    Gems.GetAllGems()
        //    .ToList()
        //    .ForEach(gema =>
        //    {
        //        foreach (int i in Enumerable.Range(0, des.Gasto(this, gema)))
        //        {
        //            monedas.Add(gema);
        //            Gemas.Remove(gema);
        //        };
        //    });
        //    Desarrollos.Add(des);
        //    return monedas;
        //}



   


        //  /// <summary>
        //  /// Determina si el jugador puede reservar un desarrollo
        //  /// (Máximo: 3)
        //  /// </summary>
        //  /// <returns></returns>
        //  public bool PuedeReservar() => Reservadas.Count < 3;

        //  /// <summary>
        //  /// Indica si el jugador debe descartar gemas hasta tener diez
        //  /// </summary>
        //  public bool DebeDevolverGemas() => Gemas.Count > 10;



        //  /// <summary>
        //  /// Devuelve un desarrollo si hubiera alguno que hiciera al jugador obtener una victoria segura
        //  /// </summary>
        //  /// <param name="desarrollos"></param>
        //  /// <param name="puntuacionObjetivo"></param>
        //  /// <returns></returns>
        //  public Development VictoriaSegura(IEnumerable<Development> desarrollos, int puntuacionObjetivo = 15)
        //  => desarrollos.Where(x => x.ComprableConOro(this)).FirstOrDefault(d => d.Prestige + Prestigio() >= puntuacionObjetivo);

        //  /// <summary>
        //  /// Devuelve el desarrollo que le salga más barato de una lista propuesta
        //  /// 1 Menos oro
        //  /// 2 Menor número de gemas
        //  /// </summary>
        //  /// <param name="desarrollos"></param>
        //  /// <returns></returns>
        //  public Development MejorDesarrollo(IEnumerable<Development> desarrollos) => MejoresDesarrollo(desarrollos).FirstOrDefault();

        //  /// <summary>
        //  /// Devuelve los desarrollos más baratos de una lista propuesta
        //  /// 1 Menos oro
        //  /// 2 Menor número de gemas
        //  /// </summary>
        //  /// <param name="desarrollos"></param>
        //  /// <returns></returns>
        //  public IEnumerable<Development> MejoresDesarrollo(IEnumerable<Development> desarrollos)
        //  {
        //      int menorOro = desarrollos.Min(x => x.OroNecesario(this)); //menor oro gastable
        //      return desarrollos.OrderBy(x => x.OroNecesario(this).Equals(menorOro)).ThenBy(x => x.Gasto(this));
        //  }

        //public override string ToString() => $"{Silueta.Nombre} ({Prestigio()} punto{(Prestigio() != 1 ? "s" : "")})";
        //public override bool Equals(object obj)
        //{
        //    if (obj == null || GetType() != obj.GetType())
        //        throw new ArgumentException("Para comparar dos instancias de " + GetType() + " deben ser del mismo tipo");
        //    return ((Jugador)obj).Id == Id;
        //}
        //public override int GetHashCode() => Id.GetHashCode();
    }
}
