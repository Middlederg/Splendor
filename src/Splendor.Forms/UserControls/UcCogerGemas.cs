using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class UcCogerGemas : UcBase
    {
        private Juego j;
        private List<Gem> GemasSeleccionadas;
        private IEnumerable<UcGemaIndividual> GetUcGemas => TlpPrincipal.Controls.OfType<UcGemaIndividual>();

        public UcCogerGemas(Juego juego)
        {
            InitializeComponent();
            foreach (var uc in GetUcGemas)
                uc.OnGemaDeleted += EliminarGema;
            j = juego;
            OnReiniciar();
        }

        public void OnReiniciar()
        {
            GemasSeleccionadas = new List<Gem>();
            foreach (var uc in GetUcGemas)
                uc.Gema = null;            
            BtnOk.Visible = false;
        }

        public void Actualizar(Gem gema)
        {
            Visible = j.TurnoDelJugador;

            if (Anexable(gema))
            {
                GemasSeleccionadas.Add(gema);
                GetUcGemas.First((Func<UcGemaIndividual, bool>)(x=> (bool)(x.Gema == null))).Gema = gema;
            }
            BtnOk.Visible = PuedeCogerGemas();
        }

        /// <summary>
        /// Indica si la gema se puede añadir a la lista
        /// </summary>
        /// <param name="gema"></param>
        /// <returns></returns>
        public bool Anexable(Gem gema)
        {
            if (GemasSeleccionadas.Count == 3) return false;
            if (GemasSeleccionadas.Count == 2 && GemasSeleccionadas.Contains(gema)) return false;
            if (GemasSeleccionadas.Contains(gema) && !j.PuedeCogerDosGemas(gema)) return false;
            return true;
        }

        private bool PuedeCogerGemas()
            => (GemasSeleccionadas.Count == 2 && (GemasSeleccionadas.Distinct().Count() == 1)
                || GemasSeleccionadas.Count == 3 && (GemasSeleccionadas.Distinct().Count() == 3));

        private void EliminarGema(Gem gema)
        {
            GemasSeleccionadas.Remove(gema);
            BtnOk.Visible = PuedeCogerGemas();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            j.CogerGemas(GemasSeleccionadas, j.Jugadores[0]);
            OnReiniciar();
            Visible = false;
        }
    }
}
