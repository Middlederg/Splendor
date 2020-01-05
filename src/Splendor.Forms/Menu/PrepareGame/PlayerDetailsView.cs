using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class PlayerDetailsView : BaseForm
    {
        public Avatar Avatar
        {
            get => AvatarSelector.CurrentAvatar;
            set
            {
                if (!(value is null))
                {
                    AvatarSelector.CurrentAvatar = value;
                }
            }
        }

        public ColorGroup ColorGroup
        {
            get => ColorFactory.GetColor(ColorSelector.CurrentColor);
            set
            {
                if (!(value is null))
                {
                    ColorSelector.CurrentColor = value.PlayingColor;
                }
            }
        }

        public string PlayerName
        {
            get => TextBoxName.Text;
            set => TextBoxName.Text = value;
        }

        public PlayerDetailsView(string title)
        {
            InitializeComponent();
            SetText(title);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PlayerName))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
