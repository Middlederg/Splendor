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
        private readonly Juego j;
        private Jugador GetJugador => j.Jugadores[IdJugador];
        private readonly int IdJugador;
        private readonly UcCuadroValores valores;

        public UcCuadroJugador() { InitializeComponent(); }

        public UcCuadroJugador(Juego juego, int idJugador)
        {
            InitializeComponent();
            j = juego;
            IdJugador = idJugador;
            j.UpdateJugadores += Actualizar;
            pInterior.BackgroundImage = Comun.GetImage($"Silueta{GetJugador.Silueta.Id}");
            pInterior.BackgroundImageLayout = ImageLayout.Center;
            LblNombre.Text = GetJugador.Nombre;
            if (IdJugador != 0)
            {
                valores = new UcCuadroValores(j, IdJugador) { Dock = DockStyle.Fill, Visible = false };
                pInterior.Controls.Add(valores);
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
                pInterior.BackgroundImage = Comun.GetImage("");
                valores.Visible = true;
                LblNombre.Visible = false;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
           if (IdJugador != 0)
            {
                pInterior.BackgroundImage = Comun.GetImage($"Silueta{GetJugador.Silueta.Id}");
                valores.Visible = false;
                LblNombre.Visible = true;
            }
        }
    }
}
