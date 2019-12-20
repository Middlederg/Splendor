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
    public partial class UcGemaIndividual : UcBase
    {
        public Action<Gema> OnGemaDeleted { get; set; }

        private Gema? gema;
        [Description("Gema asociada")]
        public Gema? Gema
        {
            get => gema;
            set
            {
                gema = value;
                Visible = gema.HasValue;
                if (gema.HasValue)
                {
                    Pbx.Image = Comun.GetImage(gema.Value.ToString().ToLower());
                    ToolTipAyuda.SetToolTip(Pbx, gema.Value.DisplayName().ToString());
                }
                else
                {
                    Pbx.Image = Comun.GetImage("");
                    ToolTipAyuda.SetToolTip(Pbx, "");
                }
            }
        }

        [Description("Si la gema tiene una x pequeña superior")]
        [DefaultValue(false)]
        public bool Eliminable
        {
            get => BtnDelete.Visible;
            set => BtnDelete.Visible = value;
        }

        public UcGemaIndividual()
        {
            InitializeComponent();
        }

        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (gema.HasValue)
                OnGemaDeleted(gema.Value);
            Gema = null;
        }
    }
}
