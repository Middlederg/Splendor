using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Core.Model;

namespace Splendor.Forms.UserControls
{
    public partial class UcNobles : UserControl
    {
        private Juego j;

        public UcNobles(Juego juego)
        {
            InitializeComponent();
            j = juego;
            Recargar();
            j.UpdateNobles += Recargar;
        }

        public void Recargar()
        {
            //Vacía todos los nobles
            foreach (var uc in Flp.Controls.OfType<UcNoble>())
                uc.Noble = null;

            //Asigna los nobles
            for (int i = 0; i < j.Nobles.Count; i++)
            {
                var noble = j.Nobles[i];
                (Flp.Controls[i] as UcNoble).Noble = j.Nobles[i];
            }
            AnchoNobles();
        }

        private void AnchoNobles() => Height = j.Nobles.Count * 155;
        


    }
}
