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
    public partial class FrmSeleccionarNoble : Form
    {
        public Noble NobleSeleccionado => Flp.Controls.OfType<UcNoble>().FirstOrDefault(x=> x.Seleccionada)?.Noble;
        
        public FrmSeleccionarNoble(List<Noble> nobles)
        {
            InitializeComponent();
            BtnOk.Enabled = false;            

            //Asigna los nobles
            for (int i = 0; i < nobles.Count; i++)
            {
                var noble = nobles[i];
                (Flp.Controls[i] as UcNoble).Noble = nobles[i];
                (Flp.Controls[i] as UcNoble).Activable = true;
            }
        }

        private void NobleClicked(object sender, EventArgs e)
        {
            foreach (var n in Flp.Controls.OfType<UcNoble>())
                n.Seleccionada = false;

            (sender as UcNoble).Seleccionada = true;
            BtnOk.Enabled = true;
        }

        private void BtnOk_Click(object sender, EventArgs e) => Close();
    }
}
