using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Domain;
using Splendor.Forms.Model;

namespace Splendor.Forms.UserControls
{
    public partial class UcGemaIndividual : UcBase
    {
        public Action<Gem> OnGemaDeleted { get; set; }

        private Gem gema;
        [Description("Gema asociada")]
        public Gem Gema
        {
            get => gema;
            set
            {
                gema = value;
                Visible = gema != null;
                if (gema != null)
                {
                    Pbx.Image = gema.GetImage();
                    ToolTipAyuda.SetToolTip(Pbx, gema.ToString());
                }
                else
                {
                    Pbx.Image = null;
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
            if (gema != null)
                OnGemaDeleted(gema);
            Gema = null;
        }
    }
}
