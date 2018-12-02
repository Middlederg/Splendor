using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Core.Model;
using Splendor.Core;

namespace Splendor.Forms.UserControls
{
    public partial class UcMiniGema : UcBase
    {

        [Description("Número de gemas")]
        public int Numero
        {
            get => Int32.Parse(Lbl.Text);
            set
            {
                pContenedor.Visible = value > 0;
                Lbl.Text = value.ToString();
                if (value > 0)
                    ToolTipAyuda.SetToolTip(Lbl, $"{TipoGema.Plural(value)}");
            }
        }

        private Gema tipoGema;
        [Description("Gema asociada")]
        public Gema TipoGema
        {
            get => tipoGema;
            set
            {
                tipoGema = value;
                pContenedor.BackgroundImage = Comun.ObtenerRecurso(value.ToString() + "Back");
            }
        }

        [Description("Fuente del número")]
        public Font Fuente
        {
            get => Lbl.Font;
            set => Lbl.Font = value;
        }

        public UcMiniGema()
        {
            InitializeComponent();
        }
    }
}
