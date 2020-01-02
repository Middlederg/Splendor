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
    public partial class TitleControl : BaseUserControl
    {
        public string Title
        {
            get => TitleLabel.Text;
            set => TitleLabel.Text = value;
        }

        public Color FontColor
        {
            get => LineLabel.BackColor;
            set => LineLabel.BackColor = TitleLabel.ForeColor = value;
        }

        public Color TitleBackColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        public TitleControl()
        {
            InitializeComponent();
        }
    }
}
