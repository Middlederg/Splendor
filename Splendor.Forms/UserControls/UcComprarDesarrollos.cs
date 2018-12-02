using Splendor.Core.Model;
using Splendor.Forms.Model;
using Splendor.Forms.Views;
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
    public partial class UcComprarDesarrollos : UcBase
    {
        private Juego j;
        private Desarrollo desarrolloSeleccionado;

        public UcComprarDesarrollos(Juego juego)
        {
            InitializeComponent();
            j = juego;
            Visible = false;
        }

        public void Actualizar((EstadoCarta estado, Desarrollo desarrollo) selected)
        {
            Visible = j.TurnoDelJugador;
            BtnComprar.Enabled = PuedeComprar(selected.estado, selected.desarrollo);
            BtnReservar.Enabled = PuedeReservar();
        }

        private bool PuedeComprar(EstadoCarta estado, Desarrollo d)
        {
            if (EstadoCarta.Desarrollo == estado)
            {
                desarrolloSeleccionado = d;
                return d.ComprableConOro(j.Jugadores[0]);
            }
            return false;
        }

        private bool PuedeReservar() => j.Jugadores[0].PuedeReservar();

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            j.CompraDesarrollo(desarrolloSeleccionado, j.Jugadores[0]);
            Visible = false;
            VisitaNobles();
        }

        private void VisitaNobles()
        {
            var nobles = j.PosiblesNoblesVisitados(j.Jugadores[0]);
            if(nobles.Any())
            {
                var noble = nobles.First();
                if (nobles.Count() > 1)
                {
                    using (var f = new FrmSeleccionarNoble(j.Nobles))
                    {
                        f.ShowDialog();
                        noble = f.NobleSeleccionado;
                    }
                }
                j.RecibirNoble(noble, j.Jugadores[0]);
            }
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            j.ReservaDesarrollo(desarrolloSeleccionado, j.Jugadores[0]);
            Visible = false;
        }
    }
}
