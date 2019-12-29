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
            game = new Game((Prestige)15, new Profile(1, "Jors", isPlayer:true), Profiles.Danilo);

            AddDeckPanel();
            AddGemsPanels();
            AddNobles();
            AddPlayers();
        }

        private void AddDeckPanel()
        {
            DeckBoard.Deck = game.Deck;
            DeckBoard.SetHumanPlayer(game.Players[0]);
            DeckBoard.OnSelectedDesarrolloChanged += DesarrolloSelected;
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

        private void DesarrolloSelected(object sender, DevelopmentEventArgs e)
        {
            developmentsPanel.Visible = true;
            gemsPanel.Visible = false;
            developmentsPanel.Development = e.Development;
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

        public void AddNobles()
        {
            NoblesBoard.NobilityBox = game.NobilityBox;
            NoblesBoard.Draw();
        }

        private void AddPlayers()
        {
            MainPlayerValues.Player = game.Players[0];
            MainPlayerValues.Draw();

            foreach (Player player in game.Players.Skip(1))
            {
                var playerboard = new PlayerBoard()
                {
                    Player = player,
                    Margin = new Padding(0)
                };
                playerboard.Draw();
                FlpJugadores.Controls.Add(playerboard);
            }
        }

        //private void AgregarJugadorPrincipal()
        //{
        //    UcJugador u = new UcJugador(j) { Dock = DockStyle.Fill };
        //    TlpGeneral.Controls.Add(u, 2, 3);
        //}



        //private void AgregarCuadrosJugadores()
        //{
        //    foreach (Jugador jugador in j.RestoJugadores(j.Jugadores[0]))
        //    {
        //        FlpJugadores.Controls.Add(new UcCuadroJugador(j, j.Jugadores.IndexOf(jugador)) { Margin = new Padding(0, 0, 0, 20)});
        //    }
        //    pJugador1.Controls.Add(new UcCuadroJugador(j, 0) { Margin = new Padding(0, 0, 0, 20) });
        //}


        private Noble TryVisitNoble()
        {
            return null;
        }

        private void OnPlay()
        {
            developmentsPanel.Reset();
            gemsPanel.Reset();
            
            while (!game.CurrentPlayer.Profile.IsPlayer)
            {
                var moveService = new MoveService(game);
                var move = moveService.MakeMove();

                using (var view = new GameActionInfo())
                {
                    view.Message = move.ToString();
                    view.SetText($"{game.CurrentPlayer.ToString()}");
                    view.ShowDialog();
                }
                game.NextTurn();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            OnPlay();
        }
    }
}
