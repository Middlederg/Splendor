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
    public partial class PlayerFace : BaseUserControl
    {
        public bool DetailsVisible
        {
            get => OpenButton.Visible;
            set => OpenButton.Visible = value;
        }

        private ColorGroup color;
        public ColorGroup Color
        {
            get => color;
            set
            {
                color = value;
                NameLabel.BackColor = value?.StrongColor ?? Configuration.DefaultColorGroup.StrongColor;
                pGeneral.BackColor = value?.SoftColor ?? Configuration.DefaultColorGroup.SoftColor;
            }
        }

        public event EventHandler OnDetailsClicked;

        public void SetAvatar(Avatar avatar)
        {
            if (avatar != null)
            {
                ProfilePanel.BackgroundImage = avatar.GetImage();
                NameLabel.Text = avatar.ToString();
            }
        }

        public PlayerFace()
        {
            InitializeComponent();
            PrestigeLabel.Text = "0";
        }

        public void SetPrestige(int prestige) => PrestigeLabel.Text = prestige.ToString();

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OnDetailsClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
