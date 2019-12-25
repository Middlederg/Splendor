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
        public int Numero
        {
            get => int.Parse(Lbl.Text);
            set
            {
                Lbl.Text = value.ToString();
                ToolTipAyuda.SetToolTip(Lbl, $"{value.ToString()} development{(value != 1 ? "s" : "")}");
            }
        }

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
