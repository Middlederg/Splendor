using Splendor.Core;
using Splendor.Core.Model;
using Splendor.Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class UcNoble : UcBase
    {
        private Noble noble;
        [Description("Noble asociado")]
        public Noble Noble
        {
            get => noble; 
            set
            {
                noble = value;
                Pbx.Image = Comun.GetImage(value?.Ruta ?? "");
                ToolTipAyuda.SetToolTip(Pbx, value?.ToString() ?? "");
            }
        }

        [Description("Si la gema es seleccionable")]
        [DefaultValue(false)]
        public bool Activable { get; set; } = false;

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
                    BorderStyle = value ? BorderStyle.FixedSingle : BorderStyle.None;
                    seleccionada = value;
                }
            }
        }

        public UcNoble()
        {
            InitializeComponent();
        }

        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);
    }
}
