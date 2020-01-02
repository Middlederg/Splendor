using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class PlayerValues : BaseUserControl
    {
        public event EventHandler OnCloseClicked;

        private IEnumerable<ResourceControl> ResourceControls() => MainTable.Controls.OfType<ResourceControl>();

        public PlayerValues() 
        { 
            InitializeComponent();
        }

        public void SetInfo(Player player)
        {
            NameLabel.Text = player.ToString();
            NameLabel.BackColor = CloseButton.BackColor = player.Profile.Color.StrongColor;
            int i = 0;
            foreach (var gem in Gems.GetAllGems())
            {
                ResourceControls().ElementAt(i).Developments = player.GetDevelopmentsOfType(gem);
                ResourceControls().ElementAt(i).Gems = player.GemsOfType(gem);
                i++;
            }

            PrestigeLabel.Text = ((int)player.Prestige).ToString();

            NoblesButton.Text = player.VisitedNobles.Count().ToString();
            NoblesButton.FlatAppearance.MouseOverBackColor = player.Profile.Color.SoftColor.Darken(10);
            NoblesButton.Visible = player.VisitedNobles.Any();
            NoblesButton.Tag = player.VisitedNobles;

            ReservesButton.Text = player.ReservedDevelopments.Count().ToString();
            ReservesButton.Visible = player.ReservedDevelopments.Any();

            GoldCounter.Gems = player.GemsOfType(Gems.Gold);
            GoldCounter.Visible = player.GemsOfType(Gems.Gold).Any();

            TotalGemsButton.Text = $"{player.TotalGems().ToString()}/10";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            OnCloseClicked?.Invoke(this, EventArgs.Empty);
        }

        private void NoblesButton_Click(object sender, EventArgs e)
        {
            using(var noblesView = new NoblesView(NoblesButton.Tag as IEnumerable<Noble>, selectionAvaliable: false, "Nobles"))
            {
                noblesView.ShowDialog();
            }
        }
    }
}
