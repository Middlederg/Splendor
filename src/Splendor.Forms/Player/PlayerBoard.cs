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
        public Color StrongColor
        {
            get => PlayerFace.StrongColor;
            set => PlayerFace.StrongColor = value;
        }

        public Color SoftColor
        {
            get => PlayerFace.SoftColor;
            set => PlayerFace.SoftColor = value;
        }

        private Player player;
        public Player Player
        {
            get => player;
            set
            {
                player = value;
                
                if (!(player is null))
                {
                    PlayerFace.SetProfile(player.Profile);
                    player.Subscribe(Draw);
                }
            }
        }

        public PlayerBoard() 
        { 
            InitializeComponent();

            PlayerFace.OnDetailsClicked += PlayerFaceDetailsClicked;
            PlayerValues.OnCloseClicked += PlayerValuesClosed;
            PlayerValues.Visible = false;
        }

        private void PlayerFaceDetailsClicked(object sender, EventArgs e)
        {
            MainTable.ColumnStyles[1].Width = 0;
            MainTable.ColumnStyles[0].Width = 100;
            PlayerValues.Size = new Size(200, 200);
            PlayerValues.Visible = true;
            PlayerValues.BackColor = SoftColor;
        }

        private void PlayerValuesClosed(object sender, EventArgs e)
        {
            MainTable.ColumnStyles[1].Width = 100;
            MainTable.ColumnStyles[0].Width = 0;
            PlayerFace.Size = new Size(150, 144);
            PlayerValues.Visible = false;
        }

        public void Draw()
        {
            PlayerFace.SetPrestige(player.Prestige);
            PlayerValues.SetInfo(player);
        }
    }
}
