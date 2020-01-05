using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class Face : BaseUserControl
    {
        private Avatar avatar;
        public Avatar Avatar
        {
            get
            {
                avatar?.SetName(NameLabel.Text);
                return avatar;
            }

            set
            {
                avatar = value;
                SetAvatar();
            }
        }

        private ColorGroup color;
        public ColorGroup Color
        {
            get => color;
            set
            {
                color = value;
                if (color != null)
                {
                    pGeneral.BackColor = color.SoftColor;
                    NameLabel.BackColor = RemoveButton.BackColor = color.StrongColor;
                }
            }
        }

        public string SetPlayerName(string name) => NameLabel.Text = name;

        public Face()
        {
            InitializeComponent();
        }

        public void SetAvatar()
        {
            if (!(avatar is null))
            {
                AvatarPanel.BackgroundImage = avatar.GetImage();
                NameLabel.Text = avatar.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (var playerDetailsView = new PlayerDetailsView("Edit player"))
            {
                playerDetailsView.Avatar = avatar;
                playerDetailsView.ColorGroup = color;
                playerDetailsView.PlayerName = NameLabel.Text;
                if (playerDetailsView.ShowDialog() == DialogResult.OK)
                {
                    Avatar = playerDetailsView.Avatar;
                    Color = playerDetailsView.ColorGroup;
                    SetPlayerName(playerDetailsView.PlayerName);
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
