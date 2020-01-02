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
    public partial class PrepareGame : BaseUserControl
    {
        public event EventHandler OnBackButtonClicked;
        public event EventHandler OnPlayButtonClicked;

        public PrepareGame()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            OnPlayButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
