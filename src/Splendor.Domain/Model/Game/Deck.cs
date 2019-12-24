using System;
using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public class Deck
    {
        public const int VisibleDevelopmentsPerRow = 4;

        private readonly List<Development> deck;

        private Action updateDeck;
        public void Subscribe(Action action) => updateDeck += action;

        public Deck()
        {
            deck = DevelopmentsFactory.GetDeck().ToList();
        }

        public int RemainigDeckCards(Level nivel) => Math.Max(0, deck.Count(x => x.Level == nivel) - 4);

        public void BuyCard(Development development)
        {
            if (!IsVisible(development))
                throw new DomainException($"Can not take {development.ToString()} because it is not visible");

            TakeCard(development);
        }

        public void ReserveCard(Development development) => TakeCard(development);

        private void TakeCard(Development development)
        {
            var taken = deck.Remove(development);
            if (!taken)
                throw new NotFoundException(nameof(Development));

            updateDeck?.Invoke();
        }

        public bool IsVisible(Development development) => VisibleDevelopments().Contains(development);
        public Development HiddenDevelopment(Level level)
        {
            if (RemainigDeckCards(level) > 0)
                return deck.Where(x => x.Level == level).ElementAt(4);
            return null;
        }

        public IEnumerable<Development> VisibleDevelopments()
        {
            foreach (Level level in Level.AllLevels)
                foreach (var development in VisibleDevelopments(level))
                    yield return development;
        }

        public IEnumerable<Development> VisibleDevelopments(Level level) => deck.Where(x => x.Level == level).Take(VisibleDevelopmentsPerRow);
    }
}
