using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Core.Model;
using Splendor.Forms.Model;
using Splendor.Core;

namespace Splendor.Forms.UserControls
{
    public partial class UcGema : UcBase
    {
        private Gema? gema;
        [Description("Gema asociada")]
        public Gema? Gema
        {
            get => gema;
            set
            {
                gema = value;
                if (gema.HasValue)
                {
                    Pbx.Image = Comun.GetImage(gema.Value.ToString().ToLower());
                    ToolTipAyuda.SetToolTip(Pbx, gema.Value.DisplayName().ToString());
                }
                else
                {
                    Pbx.Image = null;
                    ToolTipAyuda.SetToolTip(Pbx, "");
                    SubIndice = 0;
                }
            }
        }

        private int subIndice;
        [Description("Subindice que indica el número de gemas")]
        public int SubIndice {
            get => subIndice;
            set
            {
                subIndice = value;
                Refresh();
            }
        }

        [Description("Si la gema es seleccionable")]
        [DefaultValue(false)]
        public bool Activable { get; set; }

        private bool seleccionada;
        [Description("Si la gema está seleccionada")]
        [DefaultValue(false)]
        public bool Seleccionada
        {
            get => seleccionada;
            set
            {
                if (Activable)
                {
                    //BackColor = value ? Aspecto.Secondary : Color.Transparent;
                    //BorderStyle = value ? BorderStyle.FixedSingle : BorderStyle.None;
                    seleccionada = value;
                }
            }
        }

        [Description("Borde interior de la gema")]
        [DefaultValue(BorderStyle.None)]
        public BorderStyle BordeInterior
        {
            get => Pbx.BorderStyle;
            set => Pbx.BorderStyle = value;
        }

        public UcGema()
        {
            InitializeComponent();
            Pbx.Image = Comun.GetImage("diamante");
            //if (Gema.HasValue && SubIndice > 0)
            //    Gema(Gema.Value, SubIndice, false);
        }

        public void Inicializar()
        {
            Gema = null;
            Pbx.Image = null;
            Seleccionada = false;
            Activable = false;
            ToolTipAyuda.SetToolTip(Pbx, "");
        }

        /// <summary>
        /// La gema se coge y se procesa la información
        /// </summary>
        public Gema Coger()
        {
            var gema = Gema;
            SubIndice--;
            return gema ?? throw new ArgumentNullException("Ninguna gema seleccionada");
        }

        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (SubIndice > 0)
            {
                int lado = 20;
                var rectangulo = new RectangleF(0, Height - lado, lado, lado);
                e.Graphics.DrawString(SubIndice.ToString(), new Font("Verdana", 13, FontStyle.Bold), Brushes.Black, rectangulo);
            }
        }
    }
}
