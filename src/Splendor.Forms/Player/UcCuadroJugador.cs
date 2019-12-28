using Splendor.Domain;
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
        public UcCuadroJugador() 
        { 
            InitializeComponent(); 
        }

        //public UcCuadroJugador(Juego juego, int idJugador)
        //{
        //    InitializeComponent();
        //    j = juego;
        //    IdJugador = idJugador;
        //    j.UpdateJugadores += Actualizar;
        //    pInterior.BackgroundImage = new NamedPath($"Silueta{GetJugador.Silueta.Id}").GetImage();
        //    pInterior.BackgroundImageLayout = ImageLayout.Center;
        //    LblNombre.Text = GetJugador.Nombre;
        //    if (IdJugador != 0)
        //    {
        //        valores = new UcCuadroValores(j, IdJugador) { Dock = DockStyle.Fill, Visible = false };
        //        pInterior.Controls.Add(valores);
        //    }
        //    Actualizar();
        //}

        //public void Actualizar()
        //{
        //    if (IdJugador != 0)
        //        valores.Actualizar(GetJugador);
        //    LblPrestigio.Text = GetJugador.Prestigio().ToString();
        //    BtnDesarrollos.Text = GetJugador.Reservadas.Count.ToString();
        //    BtnNobles.Text = GetJugador.NoblesVisitados.Count.ToString();
        //}
    }
}
