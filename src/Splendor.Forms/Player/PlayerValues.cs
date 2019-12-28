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
    public partial class PlayerValues : UcBase
    {
        private IEnumerable<ResourceControl> ResourceControls() => MainTable.Controls.OfType<ResourceControl>();

        public PlayerValues() 
        { 
            InitializeComponent();
        }

        public void SetInfo(Player player)
        {
            int i = 0;
            foreach (var gem in Gems.GetAllGems())
            {
                ResourceControls().ElementAt(i).Developments = player.GetDevelopmentsOfType(gem);
                ResourceControls().ElementAt(i).Gems = player.GemsOfType(gem);
                ResourceControls().ElementAt(i).BackColor = gem.SoftBackColor();
                i++;
            }
            
            NoblesButton.Text = player.VisitedNobles.Count().ToString();
            ReservesButton.Text = player.ReservedDevelopments.Count().ToString();
            GoldCounter.Gems = player.GemsOfType(Gems.Gold);
            TotalGemsButton.Text = $"{player.TotalGems().ToString()}/10";
        }
    }
}
