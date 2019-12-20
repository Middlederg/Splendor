using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.CustomControls
{
    public partial class OvalPanel : Control
    {
        public OvalPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int distancia = 4;
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.Red, 0.00f)), distancia / 2, distancia / 2, Width - distancia, Height - distancia, 8);
        }
    }
}
