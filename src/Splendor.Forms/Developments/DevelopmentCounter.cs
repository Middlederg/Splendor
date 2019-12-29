using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class DevelopmentCounter : UcBase
    {
        private IEnumerable<Development> developments;
        public IEnumerable<Development> Developments
        {
            get => developments;
            set
            {
                developments = value;
                if (value != null)
                {
                    var count = value.Count();
                    Lbl.Text = count.ToString();
                    Font = new Font(new FontFamily("Verdana"), (count > 9) ? 6 : 14, FontStyle.Bold);
                    Lbl.Visible = count > 0;
                    ToolTipAyuda.SetToolTip(Lbl, developments.JoinList());

                    Lbl.BackColor = (value.Any() && value.Distinct().Count() == 1) ? value.First().Bonus.StrongBackColor() : Color.White;
                    Lbl.ForeColor = Lbl.BackColor == Color.White ? Color.Black : Color.White;
                    Lbl.BorderStyle = Lbl.BackColor == Color.White ? BorderStyle.FixedSingle : BorderStyle.None;
                }
            }
        }

        public DevelopmentCounter()
        {
            InitializeComponent();
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            if (developments.Any())
            {
                using (var developmentsView = new DevelopmentList())
                {
                    developmentsView.Developments = developments.ToList();
                    developmentsView.ShowDialog();
                }
            }
        }
    }
}
