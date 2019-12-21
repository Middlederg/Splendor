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
    public partial class UcJugador : UcBase
    {
        private Juego j;

        public UcJugador(Juego juego)
        {
            InitializeComponent();
            j = juego;
            j.UpdateJugadores += Recargar;
            Recargar();
        }

        public void Recargar()
        {
            foreach (var item in TlpPrincipal.Controls.OfType<UcRecurso>())
            {
                item.NumeroGemas = j.Jugadores[0].TotalGemas(item.TipoGema);
                item.NumeroDesarrollos = j.Jugadores[0].Bonificacion(item.TipoGema);
            }
            Oro.Numero = j.Jugadores[0].TotalGemas(Gems.Gold);
            LblNumGemas.Text = $"{j.Jugadores[0].TotalGemas()} / 10";
            ToolTipAyuda.SetToolTip(LblNumGemas, $"Tienes {j.Jugadores[0].TotalGemas()}.\n Puedes llegar a tener, como máximo, 10 gemas");
            LblNumeroNobles.Text = $"Nobles ({j.Jugadores[0].NoblesVisitados.Count})";
        }
    }
}
