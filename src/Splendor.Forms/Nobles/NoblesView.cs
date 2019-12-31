using FontAwesome.Sharp;
using Splendor.Domain;
using Splendor.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.Views
{
    public partial class NoblesView : BaseForm
    {
        private readonly bool selectionAvaliable;

        public Noble SelectedNoble => Flp.Controls.OfType<NobleTile>().FirstOrDefault(x=> x.Selected)?.Noble;

        public NoblesView(IEnumerable<Noble> nobles, bool selectionAvaliable = true, string title = "Choose a noble")
        {
            InitializeComponent();
            this.selectionAvaliable = selectionAvaliable;
            SetText(title);
            NobleName.Text = "";
            BtnOk.Enabled = false;
            BtnOk.Visible = selectionAvaliable;

            foreach (var noble in nobles)
            {
                var nobletile = new NobleTile()
                {
                    Noble = noble,
                    Activable = selectionAvaliable,
                    Margin = new Padding(0, 0, 15, 0)
                };
                nobletile.Click += NobleClicked;
                Flp.Controls.Add(nobletile);
            }

            CloseEnabled = !selectionAvaliable;
        }

        private void NobleClicked(object sender, EventArgs e)
        {
            foreach (var noble in Flp.Controls.OfType<NobleTile>())
            {
                noble.Selected = false;
            }

            (sender as NobleTile).Selected = true;
            NobleName.Text = (sender as NobleTile).Noble.ToStringDetailed();
            if (selectionAvaliable)
            {
                BtnOk.Enabled = true;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e) => Close();
    }
}
