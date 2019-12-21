using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Splendor.Forms.Model;
using FontAwesome.Sharp;
using Splendor.Domain;

namespace Splendor.Forms.UserControls
{
    public partial class UcTablero : UserControl
    {
        private readonly Juego j;
        public bool DesarrollosActivables { get; set; }
        public Action OnSelectedDesarrolloChanged { get; set; }

        public IEnumerable<UcCarta> GetCartas(Level nivel) => PanelNivel(nivel).Controls.OfType<UcCarta>();
        public IEnumerable<UcCarta> GetCartas()
        {
            foreach (Level nivel in Enum.GetValues(typeof(Level)))
                foreach (var uc in PanelNivel(nivel).Controls.OfType<UcCarta>())
                    yield return uc;
        }

        private FlowLayoutPanel PanelNivel(Level nivel)
        {
            switch (nivel)
            {
                case Level.Nivel1: return Flp1;
                case Level.Nivel2: return Flp2;
                case Level.Nivel3: return Flp3;
            }
            throw new NotImplementedException();
        }

        public UcTablero(Juego juego, bool desarrollosActivables = true, double escala = 1.0)
        {
            InitializeComponent();
            j = juego;
            DesarrollosActivables = desarrollosActivables;
            Trasera1.Mazo(Level.Nivel1, desarrollosActivables);
            Trasera2.Mazo(Level.Nivel2, desarrollosActivables);
            Trasera3.Mazo(Level.Nivel3, desarrollosActivables);
            Refrescar();
            j.UpdateDesarrollos += Refrescar;
            j.UpdateGemas += Refrescar;
        }

        public void Refrescar()
        {
            //Deja vacío todo
            foreach (var uc in GetCartas())
                uc.Inicializar();

            //Carga desarrollos visibles
            CargarCartas(Level.Nivel1, Flp1);
            CargarCartas(Level.Nivel2, Flp2);
            CargarCartas(Level.Nivel3, Flp3);

            //Carga las traseras
            foreach (var trasera in new List<UcCarta>() { Trasera1, Trasera2, Trasera3 }.Where(x=> x.Estado == EstadoCarta.Trasera))
            {
                var nivel = trasera.Nivel();
                if (j.CartasMazo(nivel) > 0)
                    trasera.Mazo(nivel, DesarrollosActivables);
                else trasera.Inicializar();
            }
        }

        private void CargarCartas(Level nivel, FlowLayoutPanel flp)
        {
            int i = 0;
            foreach (var d in j.DesarrollosVisibles(nivel))
            {
                var (icon, text, ayuda) = IconoDesarrollo(d);
                (flp.Controls[i++] as UcCarta).NuevoDesarrollo(d, DesarrollosActivables, icon, text, ayuda);
            }
        }

        private void CartaClick(object sender, EventArgs e)
        {
            //Deselecciona todo
            foreach (var uc in GetCartas().Concat(new List<UcCarta>() { Trasera1, Trasera2, Trasera3}).ToList())
                uc.Seleccionado = false;

            //selecciona solo esa carta
            if (sender is UcCarta card)
            {
                card.Seleccionado = true;
                OnSelectedDesarrolloChanged();
            }
        }

        /// <summary>
        /// Devuelve el desarrollo seleccionado en el tablero
        /// </summary>
        /// <returns></returns>
        public (EstadoCarta carta, Development d) CartaSeleccionada()
        {
            var selected = GetCartas().FirstOrDefault(x => x.Seleccionado);
            if (selected == null)
                return (EstadoCarta.Empty, null);
            return (selected.Estado, selected.Desarrollo);
        }

        public (IconChar icon, string textGasto, string textAyuda) IconoDesarrollo(Development d)
        {
            string textoAyuda = d.GastoText(j.Jugadores[0]);
            if (d.Gratuito(j.Jugadores[0])) return (IconChar.Heart, textoAyuda, "Puedes comprar el desarrollo sin gastar gemas");
            if (d.ComprableSinoro(j.Jugadores[0])) return (IconChar.Check, textoAyuda, "Puedes comprar el desarrollo sin gastar oro");
            if (d.ComprableConOro(j.Jugadores[0])) return (IconChar.Exclamation, textoAyuda, "Puedes comprar el desarrollo gastando oro");
            return (IconChar.None, d.FaltanText(j.Jugadores[0]), "");
        }
    }
}
