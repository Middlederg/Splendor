using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor.Domain
{
    public class Player
    {
        public const int MaxGems = 10;

        private Action updatePlayer;
        public void Subscribe(Action action) => updatePlayer += action;

        public int Id { get; }
	    public Avatar Profile { get; }
        public List<GameAction> Moves { get; }

        public List<Gem> Gems { get; }
        public List<Gem> GemsOfType(Gem gem) => Gems.Where(x => x == gem).ToList();
        public void AddGems(params Gem[] gems)
        {
            Gems.AddRange(gems);
            updatePlayer?.Invoke();
        }

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
            updatePlayer?.Invoke();
        }

        public List<Noble> VisitedNobles { get; }
        public void AddNoble(Noble noble)
        {
            VisitedNobles.Add(noble);
            updatePlayer?.Invoke();
        }

        public List<Development> Developments { get; }
        public List<Development> GetDevelopmentsOfType(Gem gem) => Developments.Where(x => x.Bonus == gem).ToList();
        public int TotalDevelopments => Developments.Count();
        public void BuyCard(Development development)
        {
            Developments.Add(development);
            updatePlayer?.Invoke();
        }

        public List<Development> ReservedDevelopments { get; }
        public void ReserveCard(Development development)
        {
            ReservedDevelopments.Add(development);
            updatePlayer?.Invoke();
        }

        public Prestige Prestige => (Prestige) (PrestigeForNobles + PrestigeForDevelopments);
        private int PrestigeForNobles => VisitedNobles.Sum(x => x.Prestige);
        private int PrestigeForDevelopments => Developments.Sum(x => x.Prestige);

        public ColorGroup Color { get; }
        public bool IsHuman { get; }

        public Player(int id, Avatar profile, ColorGroup color, bool isHuman)
	    {
		    Id = id;
            Profile = profile;
            Color = color;
            IsHuman = isHuman;
            Gems = new List<Gem>();
            VisitedNobles = new List<Noble>();
            Developments = new List<Development>();
            ReservedDevelopments = new List<Development>();

            Moves = new List<GameAction>();
        }

        public Player Reset() => new Player(Id, Profile, Color, IsHuman);

        public int Bonus(Gem gem) => Developments.Count(x => x.Bonus == gem);
        public int PurchasingPower(Gem gema) => TotalGems(gema) + Bonus(gema);

        public override string ToString() => Profile.ToString();

      

    }
}
