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
        private TakenDevelopmentsPanel takeDevelopmentPanel;

        public MainView()
        {
            InitializeComponent();

            SetText("Splendor");

            var player2 = Profiles.Danilo;
            player2.Color = PlayerColorFactory.Gray;

            var player3 = Profiles.Debra;
            player3.Color = PlayerColorFactory.Orange;

            var player4 = Profiles.Debra;
            player4.Color = PlayerColorFactory.Green;

            game = new Game((Prestige)15, 
                new Profile(1, "Jors", isHuman:true), 
                player2,
                player3, 
                player4);

            AddDeckPanel();
            AddGemsPanels();
            AddNobles();
            AddPlayers();
        }

        private void AddDeckPanel()
        {
            DeckBoard.Deck = game.Deck;
            DeckBoard.OnSelectedDevelopmentChanged += DevelopmentSelectedInDeck;
            DeckBoard.Draw();

            takeDevelopmentPanel = new TakenDevelopmentsPanel
            {
                Market = game.Market,
                CurrentPlayer = game.CurrentPlayer,
                Visible = false
            };
            takeDevelopmentPanel.OnDevelopmentReserved += ReserveDevelopment;
            takeDevelopmentPanel.OnDevelopmentBought += BuyDevelopment;
            pOpciones.Controls.Add(takeDevelopmentPanel);
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
            takeDevelopmentPanel.Visible = true;
            gemsPanel.Visible = false;
            takeDevelopmentPanel.CurrentPlayer = game.CurrentPlayer;
            takeDevelopmentPanel.Development = e.Development;
        }

        private void GemSelectedInMarket(object sender, GemEventArgs e)
        {
            gemsPanel.Visible = true;
            takeDevelopmentPanel.Visible = false;
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
            MainPlayerFace.SetProfile(game.Players[0].Profile);

            DeckBoard.DeselectAllCards();
            takeDevelopmentPanel.Reset();
            gemsPanel.Reset();
            
            while (!game.CurrentPlayer.Profile.IsHuman)
            {
                var moveService = new MoveService(game);
                var move = moveService.MakeMove();

                var currentPlayerBoard = FlpJugadores.Controls.OfType<PlayerBoard>().First(x => x.Player == game.CurrentPlayer);
                var playerBoardLocation = currentPlayerBoard.PointToScreen(Point.Empty);
                var playerBoardSize = currentPlayerBoard.Size;

                var view = GameActionViewFactory.Create(move, game.CurrentPlayer.ToString());
                view.StartPosition = FormStartPosition.Manual;
                view.Location = new Point(playerBoardLocation.X + playerBoardSize.Width - 10, playerBoardLocation.Y + 10);
                view.TitleBackColor = game.CurrentPlayer.Profile.Color.StrongColor;
                view.BackColor = game.CurrentPlayer.Profile.Color.SoftColor;
                using (view)
                {
                    view.ShowDialog();
                }
                game.NextTurn();
            }
            DeckBoard.UpdateIcons(game.HumanPlayerWithTurn);
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
