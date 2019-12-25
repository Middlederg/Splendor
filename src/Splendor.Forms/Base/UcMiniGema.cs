using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Splendor.Domain;

namespace Splendor.Forms.UserControls
{
    public partial class UcMiniGema : UcBase
    {
        public int Numero
        {
            get => int.Parse(Lbl.Text);
            set
            {
                pContenedor.Visible = value > 0;
                Lbl.Text = value.ToString();
                if (value > 0)
                {
                    ToolTipAyuda.SetToolTip(Lbl, $"{gem?.ToString(value) ?? ""}");
                }
            }
        }

        private Gem gem;
        public Gem Gem
        {
            get => gem;
            set
            {
                gem = value;
                string path = value.Path;
                pContenedor.BackgroundImage = new NamedPath($"{path.First()}{path.Substring(1)}Back").GetImage();
            }
        }

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
