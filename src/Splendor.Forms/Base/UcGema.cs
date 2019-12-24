using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms.UserControls
{
    public partial class UcGema : UcBase
    {
        private Gem gem;
        public Gem Gem
        {
            get => gem;
            set
            {
                gem = value;
                if (value != null)
                {
                    Pbx.Image = gem.GetImage();
                    ToolTipAyuda.SetToolTip(Pbx, gem.ToString());
                }
                else
                {
                    Pbx.Image = null;
                    ToolTipAyuda.SetToolTip(Pbx, "");
                    SubIndex = 0;
                }
            }
        }

        private int subIndex;
        public int SubIndex 
        {
            get => subIndex;
            set
            {
                subIndex = value;
                Refresh();
            }
        }

        public bool Activable { get; set; }

        [DefaultValue(BorderStyle.None)]
        public BorderStyle BordeInterior
        {
            get => Pbx.BorderStyle;
            set => Pbx.BorderStyle = value;
        }

        public UcGema()
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            Gem = null;
            Pbx.Image = null;
            Activable = false;
            ToolTipAyuda.SetToolTip(Pbx, "");
        }

        /// <summary>
        /// La gema se coge y se procesa la información
        /// </summary>
        public Gem Coger()
        {
            var gema = Gem;
            SubIndex--;
            return gema ?? throw new ArgumentNullException("Ninguna gema seleccionada");
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
