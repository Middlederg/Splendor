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

        public Color StrongColor
        {
            get => NameLabel.BackColor;
            set => NameLabel.BackColor = value;
        }

        public Color SoftColor
        {
            get => pGeneral.BackColor;
            set => pGeneral.BackColor = value;
        }

        public event EventHandler OnDetailsClicked;

        public void SetProfile(Profile profile)
        {
            if (profile != null)
            {
                ProfilePanel.BackgroundImage = profile.GetImage();
                NameLabel.Text = profile.ToString();
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
