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
        public TestView()
        {
            InitializeComponent();

        
            Game game = new Game((Prestige)15, Profiles.Amanda, Profiles.Danilo);


            ucTablero1.Deck = game.Deck;
            ucTablero1.CurrentPlayer = game.CurrentPlayer;
            ucTablero1.Draw();
            //u.Dock = DockStyle.Fill;
            //Controls.Add(u);
            //Tlp.Controls.Add(u, 1, 1);
        }

    }
}
