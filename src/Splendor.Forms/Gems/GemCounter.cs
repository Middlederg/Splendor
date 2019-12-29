using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class GemCounter : UcBase
    {
        private IEnumerable<Gem> gems;
        public IEnumerable<Gem> Gems
        {
            get => gems;
            set
            {
                gems = value;
                if (value != null)
                {
                    var count = value.Count();
                    Lbl.Text = count.ToString();
                    if (count > 0)
                    {
                        if (!value.AllSame())
                            throw new DomainException("Gems must be of the same kind");
                        Lbl.Visible = Pbx.Visible = true;
                        Pbx.BackgroundImage = value.First().SmallPath.GetImage();
                        ToolTipAyuda.SetToolTip(Lbl, value.JoinList());
                        ToolTipAyuda.SetToolTip(Pbx, value.JoinList());
                    }
                    else
                    {
                        Lbl.Visible = Pbx.Visible = false;
                        ToolTipAyuda.SetToolTip(Lbl, "");
                        ToolTipAyuda.SetToolTip(Pbx, "");
                    }
                }
            }
        }

        public GemCounter()
        {
            InitializeComponent();
        }
    }
}
