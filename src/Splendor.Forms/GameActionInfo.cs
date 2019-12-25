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
    public partial class GameActionInfo : BaseForm
    {
        private readonly int waitTime;

        public string Message
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public GameActionInfo()
        {
            InitializeComponent();
            waitTime = Configuration.GetWaitTime;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            await Task.Delay(waitTime);
            Close();
        }
    }
}
