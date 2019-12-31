using Splendor.Domain;
using Splendor.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms.Views
{
    public partial class MainView : BaseForm
    {
        private readonly Game game;

        private TakenGemsPanel gemsPanel;
        private TakenDevelopmentsPanel developmentsPanel;

        public MainView()
        {
            InitializeComponent();

            SetText("Splendor");
            game = new Game((Prestige)15, new Profile(1, "Jors", isPlayer:true), Profiles.Danilo, Profiles.Debra, Profiles.Donnie);

            AddDeckPanel();
            AddGemsPanels();
            AddNobles();
            AddPlayers();
        }

        private void AddDeckPanel()
        {
            DeckBoard.Deck = game.Deck;
            DeckBoard.SetHumanPlayer(game.Players[0]);
            DeckBoard.OnSelectedDesarrolloChanged += DevelopmentSelectedInDeck;
            DeckBoard.Draw();

            developmentsPanel = new TakenDevelopmentsPanel
            {
                Market = game.Market,
                CurrentPlayer = game.CurrentPlayer,
                Visible = false
            };
            developmentsPanel.OnDevelopmentReserved += ReserveDevelopment;
            developmentsPanel.OnDevelopmentBought += BuyDevelopment;
            pOpciones.Controls.Add(developmentsPanel);
        }

        private void AddGemsPanels()
        {
            MarketBoard.Market = game.Market;
            MarketBoard.Draw();
            MarketBoard.OnGemSelected += GemSelectedInMarket;

            gemsPanel = new TakenGemsPanel
            {
                CurrentPlayer = game.CurrentPlayer,
                Market = game.Market,
                Visible = false
            };
            gemsPanel.OnGemHasBeenRemoved += GemRemoved;
            gemsPanel.OnTransactionCompleted += TakeGems;
            pOpciones.Controls.Add(gemsPanel);
        }

        public void AddNobles()
        {
            NoblesBoard.NobilityBox = game.NobilityBox;
            NoblesBoard.Draw();
        }

        private void AddPlayers()
        {
            MainPlayerFace.SetProfile(game.Players[0].Profile);
            MainPlayerValues.Player = game.Players[0];
            MainPlayerValues.Draw();

            foreach (Player player in game.Players.Skip(1))
            {
                var playerboard = new PlayerBoard()
                {
                    Player = player,
                    Margin = new Padding(0, 10, 0, 0),
                };
                playerboard.Draw();
                FlpJugadores.Controls.Add(playerboard);
            }
        }

        private void DevelopmentSelectedInDeck(object sender, DevelopmentEventArgs e)
        {
            developmentsPanel.Visible = true;
            gemsPanel.Visible = false;
            developmentsPanel.Development = e.Development;
        }

        private void GemSelectedInMarket(object sender, GemEventArgs e)
        {
            gemsPanel.Visible = true;
            developmentsPanel.Visible = false;
            gemsPanel.AddGem(e.Gem);
        }

        private void GemRemoved(object sender, GemEventArgs e)
        {
            MarketBoard.AddGem(e.Gem);
        }

        private void TakeGems(object sender, EventArgs e)
        {
            var gems = gemsPanel.GetSelectedGems().ToArray();
            var service = new TakeGemsService(game.CurrentPlayer, game.Market, gems);
            service.Take();
            gemsPanel.Reset();
            var noble = TryVisitNoble();
            game.Log.TakeGems(game.GetCurrentTurnNumber, game.CurrentPlayer, noble, gems);
            game.NextTurn();
            OnPlay();
        }

        private void BuyDevelopment(object sender, DevelopmentEventArgs e)
        {
            var service = new PurchaseService(e.Development, game.CurrentPlayer);
            service.Purchase(game.Deck, game.Market);
            var noble = TryVisitNoble();
            game.Log.BuyDevelopment(game.GetCurrentTurnNumber, game.CurrentPlayer, noble, e.Development);
            game.NextTurn();
            OnPlay();
        }

        private void ReserveDevelopment(object sender, DevelopmentEventArgs e)
        {
            var service = new ReserveService(e.Development, game.CurrentPlayer, game.Market);
            bool takeGold = service.WouldTakeGoldToken();
            service.Reserve(game.Deck);
            var noble = TryVisitNoble();
            game.Log.ReserveDevelopment(game.GetCurrentTurnNumber, game.CurrentPlayer, noble, e.Development, takeGold);
            game.NextTurn();
            OnPlay();
        }

        private Noble TryVisitNoble()
        {
            return new ReceiveVisit(game.NobilityBox, game.CurrentPlayer).Receive();
        }

        private void OnPlay()
        {
            DeckBoard.DeselectAllCards();
            developmentsPanel.Reset();
            gemsPanel.Reset();
            
            while (!game.CurrentPlayer.Profile.IsPlayer)
            {
                var moveService = new MoveService(game);
                var move = moveService.MakeMove();

                var currentPlayerBoard = FlpJugadores.Controls.OfType<PlayerBoard>().First(x => x.Player == game.CurrentPlayer);
                var playerBoardLocation = currentPlayerBoard.PointToScreen(Point.Empty);
                var playerBoardSize = currentPlayerBoard.Size;

                var view = GameActionViewFactory.Create(move, game.CurrentPlayer.ToString());
                view.StartPosition = FormStartPosition.Manual;
                view.Location = new Point(playerBoardLocation.X + playerBoardSize.Width, playerBoardLocation.Y + 40);
                using (view)
                {
                    view.ShowDialog();
                }
                game.NextTurn();
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            using (var logView = new LogView(game.Log))
            {
                logView.ShowDialog();
            }
        }

        private void OnShown(object sender, EventArgs e)
        {
            MessageBox.Show($"{game.CurrentPlayer.ToString()} begins playing");
            OnPlay();
        }
    }
}
