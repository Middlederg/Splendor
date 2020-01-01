using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.Views
{
    public partial class TestView : Form
    {
        private readonly Game game;

        public TestView()
        {
            InitializeComponent();

            game = new Game((Prestige)15, Profiles.Amanda, Profiles.Danilo);

            playerBoard1.Player = game.Players[0];
            playerBoard1.Draw();
            ucTablero1.Deck = game.Deck;
            ucTablero1.Draw();

            marketBoard1.Market = game.Market;
            marketBoard1.Draw();
            marketBoard1.OnGemSelected += GemSelectedInMarket;

            ucCogerGemas1.CurrentPlayer = game.CurrentPlayer;
            ucCogerGemas1.Market = game.Market;
            ucCogerGemas1.OnGemHasBeenRemoved += GemRemoved;
            ucCogerGemas1.OnTransactionCompleted += TakeGems;
        }

        private void GemSelectedInMarket(object sender, GemEventArgs e)
        {
            //var service = new TakeGemsService(game.CurrentPlayer, game.Market, ucCogerGemas1.GetSelectedGems().ToArray());
            ucCogerGemas1.AddGem(e.Gem);
        }

        private void GemRemoved(object sender, GemEventArgs e)
        {
            marketBoard1.AddGem(e.Gem);
        }

        private void TakeGems(object sender, EventArgs e)
        {
            var gems = ucCogerGemas1.GetSelectedGems().ToArray();
            var service = new TakeGemsService(game.CurrentPlayer, game.Market, gems);
            service.Take();
            ucCogerGemas1.Reset();
            Visible = false;
        }

        private void Tlp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
