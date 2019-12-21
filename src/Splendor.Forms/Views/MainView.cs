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
            j = new Juego(new Silueta[] { SiluetaFactory.Amanda, SiluetaFactory.Danilo, SiluetaFactory.Debra, SiluetaFactory.Denver }, 15) { Turno = 0 };
            //j = new Juego(new Silueta[] { SiluetaFactory.Amanda, SiluetaFactory.Danilo, SiluetaFactory.Debra }, 15) { Turno = 0 };
            //j = new Juego(new Silueta[] { SiluetaFactory.Amanda, SiluetaFactory.Danilo }, 15) { Turno = 0 };
            j.Jugadores[0].Gemas.AddRange(new List<Gem> { Gems.Diamond, Gems.Diamond, Gems.Gold, Gems.Sapphire, Gems.Ruby });
            j.Jugadores[0].Desarrollos.AddRange(DesarrollosFactory.GetDesarrollos());
            j.Jugadores[1].Gemas.AddRange(new List<Gem> { Gems.Diamond, Gems.Diamond, Gems.Onyx });
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
            ucGemas = new UcGemas(j) { Anchor = AnchorStyles.None };
            ucGemas.OnSelectedGemaChanged += GemaSeleccionada;
            TlpGeneral.Controls.Add(ucGemas, 3, 0);
            TlpGeneral.SetRowSpan(ucGemas, 3);
        }

        public void AgregarNobles()
        {
            UcNobles u = new UcNobles(j) { Anchor = AnchorStyles.None };
            TlpGeneral.Controls.Add(u, 4, 0);
            TlpGeneral.SetRowSpan(u, 3);
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
            if (gema != null)
            {
                ucCogerGemas.Actualizar(gema);
                ucComprarDesarrollos.Visible = false;
            }
        }

        private void OnPlay()
        {
            FlpAccionesJugadores.Controls.Clear();
            foreach (var jugador in j.RestoJugadores(j.Jugadores[0]))
            {
                if (j.Turno == j.Jugadores.IndexOf(jugador))
                {
                    IAccion accion = j.Mover();
                    FlpAccionesJugadores.Controls.Add(new UcAccion(accion, BtnAceptarMovimientoClick));
                }
                else
                {
                    FlpAccionesJugadores.Controls.Add(new UcAccion());
                }
            }
        }

        private void BtnAceptarMovimientoClick(object sender, EventArgs e)
        {
            j.AvanzaTurno();
            OnPlay();
        }
    }
}
