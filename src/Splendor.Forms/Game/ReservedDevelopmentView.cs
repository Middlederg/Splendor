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
    public partial class ReservedDevelopmentView : BaseForm, IGameActionView
    {
        private readonly ReserveDevelopment gameAction;

        public ReservedDevelopmentView(ReserveDevelopment gameAction, string playerName)
        {
            InitializeComponent();
            this.gameAction = gameAction;
            SetText(playerName);
            Draw();
        }

        private void Draw()
        {
            Card.Development = gameAction.Development;
            Card.Status = CardStatus.FaceUp;
            Card.Draw();
            if (!gameAction.TakeGold) 
                PbxGold.BackgroundImage = null;
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
        private void WindowClicked() => Close();
    }
}
