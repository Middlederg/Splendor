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
    public partial class TakenGemsView : BaseForm, IGameActionView
    {
        private readonly TakeGems gameAction;

        public TakenGemsView(TakeGems gameAction, string playerName)
        {
            InitializeComponent();
            this.gameAction = gameAction;
            SetText(playerName);
            Draw();
        }

        private void Draw()
        {
            int i = 0;
            foreach (var gem in gameAction.Gems)
            {
                Flp.Controls.OfType<PictureBox>().ElementAt(i).BackgroundImage = gem.SmallPath.GetImage();
                i++;
            }
            NobleTile.Noble = gameAction.Noble;
            MainLabel.Text = gameAction.ToString();
        }

        private async void OnShown(object sender, EventArgs e)
        {
            await Task.Delay((int)Configuration.DefaultWaitTime);
            Close();
        }

        private void OnTableClick(object sender, EventArgs e) => WindowClicked();
        private void Pbx_Click(object sender, EventArgs e) => WindowClicked();
        private void MainLabel_Click(object sender, EventArgs e) => WindowClicked();
        private void OnPanelClicked(object sender, EventArgs e) => WindowClicked();
        private void WindowClicked() => Close();

        
    }
}
