using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class PlayerBoard : UcBase
    {
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
                    ProfilePanel.BackgroundImage = player.Profile.GetImage();
                    NameLabel.Text = player.ToString();
                }
            }
        }

        public PlayerBoard() 
        { 
            InitializeComponent();

            PrestigeLabel.Text = "0";
            PlayerValues.OnCloseClicked += PlayerValuesClosed;
        }

        private void PlayerValuesClosed(object sender, EventArgs e)
        {
            PlayerValues.Visible = false;
            OpenButton.Visible = true;
        }

        public void Draw()
        {
            PlayerValues.SetInfo(player);
            PrestigeLabel.Text = ((int)player.Prestige).ToString();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            PlayerValues.Visible = true;
            OpenButton.Visible = false;
        }
    }
}
