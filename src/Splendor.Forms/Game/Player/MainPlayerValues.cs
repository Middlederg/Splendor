using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class MainPlayerValues : BaseUserControl
    {
        private IEnumerable<ResourceControl> ResourceControls() => MainTable.Controls.OfType<ResourceControl>();

        private Player player;
        public Player Player
        {
            get => player;
            set
            {
                player = value;

                if (!(player is null))
                {
                    player.Subscribe(Draw);
                }
            }
        }

        public MainPlayerValues()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            int i = 0;
            foreach (var gem in Gems.GetAllGems())
            {
                ResourceControls().ElementAt(i).Developments = player.GetDevelopmentsOfType(gem);
                ResourceControls().ElementAt(i).Gems = player.GemsOfType(gem);
                //ResourceControls().ElementAt(i).BackColor = gem.SoftBackColor();
                i++;
            }

            NoblesButton.Text = player.VisitedNobles.Count().ToString();
            NoblesButton.FlatAppearance.MouseOverBackColor = player.Color.SoftColor.Darken(10);
            NoblesButton.Visible = player.VisitedNobles.Any();
            NoblesButton.Tag = player.VisitedNobles;

            ReservesButton.Text = player.ReservedDevelopments.Count().ToString();
            ReservesButton.Visible = player.ReservedDevelopments.Any();

            GoldCounter.Gems = player.GemsOfType(Gems.Gold);
            GoldCounter.Visible = player.GemsOfType(Gems.Gold).Any();

            TotalGemsButton.Text = $"{player.TotalGems().ToString()}/10";
        }
    }
}
