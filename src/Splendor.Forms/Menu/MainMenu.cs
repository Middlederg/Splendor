using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class MainMenu : BaseUserControl
    {
        public event EventHandler<ValueEventArgs<MenuOption>> OnButtonClicked;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked?.Invoke(this, new ValueEventArgs<MenuOption>(MenuOption.Play));
        }

        private void TournamentButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked?.Invoke(this, new ValueEventArgs<MenuOption>(MenuOption.Tournament));
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked?.Invoke(this, new ValueEventArgs<MenuOption>(MenuOption.Season));
        }

        private void ConfigurationButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked?.Invoke(this, new ValueEventArgs<MenuOption>(MenuOption.Configuration));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked?.Invoke(this, new ValueEventArgs<MenuOption>(MenuOption.Exit));
        }
    }
}
