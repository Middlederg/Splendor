using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class GemToken : UcBase
    {
        public Gem Gem { get; set; }

        public int SubIndex { get; private set; }
        public void AddGems(params Gem[] gems)
        {
            SubIndex += gems.Count(x => x == Gem);
            Refresh();
        }

        public bool Activable { get; set; }

        [DefaultValue(BorderStyle.None)]
        public BorderStyle BordeInterior
        {
            get => Pbx.BorderStyle;
            set => Pbx.BorderStyle = value;
        }

        public GemToken()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            if (SubIndex > 0)
            {
                Pbx.Image = Gem.GetImage();
                ToolTipAyuda.SetToolTip(Pbx, Gem.ToString(SubIndex));
                Refresh();
            }
            else
            {
                Pbx.Image = null;
                ToolTipAyuda.SetToolTip(Pbx, "");
            }
        }

        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);
        

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (SubIndex > 0)
            {
                int lado = 20;
                var rectangulo = new RectangleF(0, Height - lado, lado, lado);
                e.Graphics.DrawString(SubIndex.ToString(), new Font("Verdana", 13, FontStyle.Bold), Brushes.Black, rectangulo);
            }
        }
    }
}
