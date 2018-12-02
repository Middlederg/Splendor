using Splendor.Core;
using Splendor.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class UcCuadroJugador : UcBase
    {
        private Juego j;
        private Jugador GetJugador => j.Jugadores[IdJugador];
        private int IdJugador;
        private UcCuadroValores valores;

        public UcCuadroJugador() { InitializeComponent(); }

        public UcCuadroJugador(Juego juego, int idJugador)
        {
            InitializeComponent();
            j = juego;
            IdJugador = idJugador;
            j.UpdateJugadores += Actualizar;
            pGeneral.BackgroundImage = Comun.ObtenerRecurso("");
            pGeneral.BackgroundImageLayout = ImageLayout.Center;

            if (IdJugador != 0)
            {
                valores = new UcCuadroValores(j, IdJugador) { Dock = DockStyle.Fill, Visible = false };
                pGeneral.Controls.Add(valores);
            }
            Actualizar();
        }

        public void Actualizar()
        {
            if (IdJugador != 0)
                valores.Actualizar(GetJugador);
            LblPrestigio.Text = GetJugador.Prestigio().ToString();
            BtnDesarrollos.Text = GetJugador.Reservadas.Count.ToString();
            BtnNobles.Text = GetJugador.NoblesVisitados.Count.ToString();
        }

        private void OnMouseOver(object sender, EventArgs e)
        {
            if (IdJugador != 0)
            {
                pGeneral.BackgroundImage = Comun.ObtenerRecurso("");
                valores.Visible = true;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
           if (IdJugador != 0)
            {
                pGeneral.BackgroundImage = Comun.ObtenerRecurso($"Silueta{GetJugador.Silueta.Id}");
                valores.Visible = false;
            }
        }
    }
}
