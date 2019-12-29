using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class DeckBoard : UcBase
    {
        private Deck deck;
        public Deck Deck
        {
            get => deck;
            set
            {
                deck = value;
                if (deck != null)
                {
                    deck.Subscribe(Draw);
                }
            }
        }

        private Player humanPlayer;
        public void SetHumanPlayer(Player humanPlayer) => this.humanPlayer = humanPlayer;

        public IEnumerable<Card> GetAllCards()
        {
            foreach (var panel in new FlowLayoutPanel[] { Flp1, Flp2, Flp3 })
            {
                foreach (var card in panel.Controls.OfType<Card>())
                {
                    yield return card;
                }
            }
            foreach (var card in new Card[] { Trasera1, Trasera2, Trasera3 })
            {
                yield return card;
            }
        }
        public Development SelectedDevelopment() => GetAllCards().FirstOrDefault(x => x.Selected)?.Development;

        public event EventHandler<DevelopmentEventArgs> OnSelectedDesarrolloChanged;

        private FlowLayoutPanel GetPanel(Level level)
        {
            if (level == Level.Level1) return Flp1;
            if (level == Level.Level2) return Flp2;
            if (level == Level.Level3) return Flp3;
            throw new NotImplementedException();
        }

        public DeckBoard()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            foreach (Level level in Level.AllLevels)
            {
                int i = 0;
                var controls = GetPanel(level).Controls.OfType<Card>();
                foreach (var development in deck.VisibleDevelopments(level))
                {
                    controls.ElementAt(i).Activable = true;
                    controls.ElementAt(i).Development = development;
                    controls.ElementAt(i).Status = CardStatus.FaceUp;
                    (IconChar icon, string helpText) = IconoDesarrollo(development);
                    controls.ElementAt(i).SetHelp(icon, helpText);
                    controls.ElementAt(i).Draw();
                    i++;
                }
            }

            DrawBack(Level.Level1, Trasera1);
            DrawBack(Level.Level2, Trasera2);
            DrawBack(Level.Level3, Trasera3);
        }

        private void DrawBack(Level level, Card card)
        {
            if (deck.RemainigDeckCards(level) > 0)
            {
                card.Status = CardStatus.FaceDown;
                card.Development = deck.HiddenDevelopment(level);
            }
            else
            {
                card.Status = CardStatus.NoCard;
                card.Development = null;
            }
            card.Draw();
        }

        private void CartaClick(object sender, EventArgs e)
        {
            DeselectAllCards();

            if (sender is Card selectedCard)
            {
                selectedCard.Selected = true;
                OnSelectedDesarrolloChanged?.Invoke(sender, new DevelopmentEventArgs(selectedCard.Development));
            }
        }

        public void DeselectAllCards()
        {
            foreach (var card in GetAllCards())
                card.Selected = false;
        }

        public (IconChar icon, string helpText) IconoDesarrollo(Development development)
        {
            var service = new PurchaseService(development, humanPlayer);
            return (GetIconChar(service), service.ToString());
        }

        private IconChar GetIconChar(PurchaseService service)
        {
            if (service.IsFree()) return IconChar.Heart;
            if (service.CanAfford()) return IconChar.Check;
            if (service.CanAffordPayingGold()) return IconChar.Exclamation;
            return IconChar.None;
        }
    }
}
