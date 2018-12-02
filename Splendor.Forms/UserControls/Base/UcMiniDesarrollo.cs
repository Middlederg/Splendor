using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class UcMiniDesarrollo : UcBase
    {
        [Description("Número de desarrollos")]
        public int Numero
        {
            get => Int32.Parse(Lbl.Text);
            set
            {
                Lbl.Text = value.ToString();
                ToolTipAyuda.SetToolTip(Lbl, value.ToString());
            }
        }

        [Description("Fuente del número")]
        public Font Fuente
        {
            get => Lbl.Font;
            set => Lbl.Font = value;
        }

        public UcMiniDesarrollo()
        {
            InitializeComponent();
        }
    }
}
