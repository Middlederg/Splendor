using Splendor.Core.Model;
using Splendor.Core.Negocio;
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
    public partial class MainView : Form
    {
        private UcTablero ucTablero;
        private UcGemas ucGemas;
        private UcComprarDesarrollos ucComprarDesarrollos;
        private UcCogerGemas ucCogerGemas;

        private Juego j;

        public MainView()
        {
            InitializeComponent();
            j = new Juego(new Silueta[] { SiluetaFactory.Amanda, SiluetaFactory.Danilo }, 15) { Turno = 0 };
            j.Jugadores[0].Gemas.AddRange(new List<Gema> { Gema.Diamante, Gema.Diamante, Gema.Oro, Gema.Zafiro, Gema.Rubi });
            j.Jugadores[0].Desarrollos.AddRange(DesarrollosFactory.GetDesarrollos());
            j.Jugadores[1].Gemas.AddRange(new List<Gema> { Gema.Diamante, Gema.Diamante, Gema.Onix });
            AgregarTablero();
            AgregarGemas();
            AgregarNobles();
            AgregarJugadorPrincipal();
            AgregarPanelesAcciones();
            AgregarCuadrosJugadores();
        }

      

        private void AgregarTablero()
        {
            ucTablero = new UcTablero(j){ Dock = DockStyle.Fill };
            ucTablero.OnSelectedDesarrolloChanged += DesarrolloSeleccionado;
            TlpGeneral.Controls.Add(ucTablero, 2, 1);
        }

        private void AgregarGemas()
        {
            ucGemas = new UcGemas(j) { Dock = DockStyle.Fill  };
            ucGemas.OnSelectedGemaChanged += GemaSeleccionada;
            TlpGeneral.Controls.Add(ucGemas, 3, 0);
            TlpGeneral.SetRowSpan(ucGemas, 2);
        }

        public void AgregarNobles()
        {
            UcNobles u = new UcNobles(j) { Dock = DockStyle.Fill };
            TlpGeneral.Controls.Add(u, 2, 0);
        }

        private void AgregarJugadorPrincipal()
        {
            UcJugador u = new UcJugador(j) { Dock = DockStyle.Fill };
            TlpGeneral.Controls.Add(u, 2, 3);
        }

        private void AgregarPanelesAcciones()
        {
            ucComprarDesarrollos = new UcComprarDesarrollos(j) { Dock = DockStyle.Fill };
            ucCogerGemas = new UcCogerGemas(j) { Dock = DockStyle.Fill };
            pOpciones.Controls.Add(ucComprarDesarrollos);
            pOpciones.Controls.Add(ucCogerGemas);
        }

        private void AgregarCuadrosJugadores()
        {
            foreach (Jugador jugador in j.RestoJugadores(j.Jugadores[0]))
            {
                FlpJugadores.Controls.Add(new UcCuadroJugador(j, j.Jugadores.IndexOf(jugador)) { Margin = new Padding(0, 0, 0, 20)});
            }
            pJugador1.Controls.Add(new UcCuadroJugador(j, 0) { Margin = new Padding(0, 0, 0, 20) });
        }

        private void DesarrolloSeleccionado()
        {
            ucComprarDesarrollos.Actualizar(ucTablero.CartaSeleccionada());
            ucCogerGemas.OnReiniciar();
            ucCogerGemas.Visible = false;
        }

        private void GemaSeleccionada()
        {
            var gema = ucGemas.GemaSelecionada();
            if (gema.HasValue)
            {
                ucCogerGemas.Actualizar(gema.Value);
                ucComprarDesarrollos.Visible = false;
            }
        }

        private void OnPlay()
        {
            if (!j.TurnoDelJugador)
            {
                j.Mover();
                j.AvanzaTurno();
            }
        }
    }
}
