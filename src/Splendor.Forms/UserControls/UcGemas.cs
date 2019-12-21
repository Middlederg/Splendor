using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms.UserControls
{
    public partial class UcGemas : UserControl
    {
        private Juego j;
        public Action OnSelectedGemaChanged { get; set; }

        public UcGemas(Juego juego)
        {
            InitializeComponent();
            j = juego;

            Refrescar();
            j.UpdateGemas += Refrescar;
        }

        public void Refrescar()
        {
            foreach (var gema in Gems.GetAllGems())
            {
                var uc = Find(gema);
                uc.SubIndice = j.NumGemasMesa(gema);
            }
        }

        public UcGema Find(Gem gema) => Flp.Controls.OfType<UcGema>().FirstOrDefault(x => x.Gema == gema);

        private void GemaClick(object sender, EventArgs e)
        {
            foreach (var uc in Flp.Controls.OfType<UcGema>().ToList())
                uc.Seleccionada = false;

            //selecciona solo esa gema
            if (sender is UcGema gema && gema.SubIndice > 0)
            {
                gema.Seleccionada = true;
                OnSelectedGemaChanged();
            }
        }

        /// <summary>
        /// Devuelve la última gema que se seleccionó
        /// </summary>
        /// <returns></returns>
        public Gem GemaSelecionada()
        {
            var selected = Flp.Controls.OfType<UcGema>().FirstOrDefault(x => x.Seleccionada);
            return selected.Gema;
        }
    }
}
