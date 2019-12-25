using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class NobleTile : UcBase
    {
        private Noble noble;
        public Noble Noble
        {
            get => noble; 
            set
            {
                noble = value;
                Pbx.Image = value.GetImage();
                ToolTipAyuda.SetToolTip(Pbx, value?.ToString() ?? "");
            }
        }

        public bool Activable { get; set; } = false;

        private bool selected;
        [DefaultValue(false)]
        public bool Selected
        {
            get => selected;
            set
            {
                if (Activable)
                {
                    BorderStyle = value ? BorderStyle.FixedSingle : BorderStyle.None;
                    selected = value;
                }
            }
        }

        public NobleTile()
        {
            InitializeComponent();
        }

        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);
    }
}
