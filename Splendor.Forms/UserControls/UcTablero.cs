using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Core.Model;
using Splendor.Core.Enumeraciones;
using Splendor.Forms.Model;
using FontAwesome.Sharp;

namespace Splendor.Forms.UserControls
{
    public partial class UcTablero : UserControl
    {
        private Juego j;
        public bool DesarrollosActivables { get; set; }
        public Action OnSelectedDesarrolloChanged { get; set; }

        public IEnumerable<UcCarta> GetCartas(NivelDesarrollo nivel) => PanelNivel(nivel).Controls.OfType<UcCarta>();
        public IEnumerable<UcCarta> GetCartas()
        {
            foreach (NivelDesarrollo nivel in EnumExtensions.GetEnumList<NivelDesarrollo>())
                foreach (var uc in PanelNivel(nivel).Controls.OfType<UcCarta>())
                    yield return uc;
        }

        private FlowLayoutPanel PanelNivel(NivelDesarrollo nivel)
        {
            switch (nivel)
            {
                case NivelDesarrollo.Nivel1: return Flp1;
                case NivelDesarrollo.Nivel2: return Flp2;
                case NivelDesarrollo.Nivel3: return Flp3;
            }
            throw new NotImplementedException();
        }

        public UcTablero(Juego juego, bool desarrollosActivables = true, double escala = 1.0)
        {
            InitializeComponent();
            j = juego;
            DesarrollosActivables = desarrollosActivables;
            Trasera1.Mazo(NivelDesarrollo.Nivel1, desarrollosActivables);
            Trasera2.Mazo(NivelDesarrollo.Nivel2, desarrollosActivables);
            Trasera3.Mazo(NivelDesarrollo.Nivel3, desarrollosActivables);
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
            CargarCartas(NivelDesarrollo.Nivel1, Flp1);
            CargarCartas(NivelDesarrollo.Nivel2, Flp2);
            CargarCartas(NivelDesarrollo.Nivel3, Flp3);

            //Carga las traseras
            foreach (var trasera in new List<UcCarta>() { Trasera1, Trasera2, Trasera3 }.Where(x=> x.Estado == EstadoCarta.Trasera))
            {
                var nivel = trasera.Nivel();
                if (j.CartasMazo(nivel) > 0)
                    trasera.Mazo(nivel, DesarrollosActivables);
                else trasera.Inicializar();
            }
        }

        private void CargarCartas(NivelDesarrollo nivel, FlowLayoutPanel flp)
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
        public (EstadoCarta carta, Desarrollo d) CartaSeleccionada()
        {
            var selected = GetCartas().FirstOrDefault(x => x.Seleccionado);
            if (selected == null)
                return (EstadoCarta.Empty, null);
            return (selected.Estado, selected.Desarrollo);
        }

        public (IconChar icon, string textGasto, string textAyuda) IconoDesarrollo(Desarrollo d)
        {
            string textoAyuda = d.GastoText(j.Jugadores[0]);
            if (d.Gratuito(j.Jugadores[0])) return (IconChar.Heart, textoAyuda, "Puedes comprar el desarrollo sin gastar gemas");
            if (d.ComprableSinoro(j.Jugadores[0])) return (IconChar.Check, textoAyuda, "Puedes comprar el desarrollo sin gastar oro");
            if (d.ComprableConOro(j.Jugadores[0])) return (IconChar.Exclamation, textoAyuda, "Puedes comprar el desarrollo gastando oro");
            return (IconChar.None, d.FaltanText(j.Jugadores[0]), "");
        }
    }
}
