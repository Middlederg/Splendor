using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Core.Model;
using Splendor.Forms.Model;
using Splendor.Core;
using FontAwesome.Sharp;

namespace Splendor.Forms.UserControls
{
    public partial class UcCarta : UcBase
    {
        [Description("Desarrollo asociado")]
        public Desarrollo Desarrollo { get; private set; }

        [Description("Si la carta es seleccionable")]
        [DefaultValue(false)]
        public bool Activable { get; set; }

        private bool seleccionado;
        [Description("Si la carta está seleccionada")]
        [DefaultValue(false)]
        public bool Seleccionado
        {
            get => seleccionado;
            set
            {
                if (Activable)
                {
                    BackColor = value ? Aspecto.Secondary : Color.Transparent;
                    //BorderStyle = value ? BorderStyle.FixedSingle : BorderStyle.None;
                    seleccionado = value;
                }
            }
        }

        [Description("Estado de la carta")]
        [DefaultValue(EstadoCarta.Empty)]
        public EstadoCarta Estado { get; private set; }

        [Description("Borde interior de la carta")]
        [DefaultValue(BorderStyle.None)]
        public BorderStyle BordeInterior
        {
            get => Pbx.BorderStyle;
            set => Pbx.BorderStyle = value;
        }

        public UcCarta()  
        {
            InitializeComponent();
        }

        public void Inicializar()
        {
            Desarrollo = null;
            Pbx.Image = null;
            Seleccionado = false;
            Activable = false;
            Estado = EstadoCarta.Empty;
            TtAyuda.SetToolTip(Pbx, "");
            SetIcono(IconChar.None, "");
        }

        /// <summary>
        /// La carta se coge y queda en estado vacío
        /// </summary>
        public Desarrollo Coger()
        {
            var d = Desarrollo.Copiar();
            Inicializar();
            return d;
        }

        /// <summary>
        /// Coloca un nuevo desarrollo sobre una loseta vacía
        /// </summary>
        public void NuevoDesarrollo(Desarrollo desarrollo, bool activable, IconChar icon, string textoCarta, string textoAyuda)
        {
            if (desarrollo == null)
                throw new ArgumentNullException(nameof(desarrollo));

            Pbx.Image = Comun.ObtenerRecurso(desarrollo.Ruta);
            Desarrollo = desarrollo;
            Activable = activable;
            Estado = EstadoCarta.Desarrollo;
            TtAyuda.SetToolTip(Pbx, textoCarta);
            SetIcono(icon, textoAyuda);
        }

        /// <summary>
        /// Marca como contenedor de un mazo de cartas 
        /// </summary>
        public void Mazo(NivelDesarrollo nivel, bool activable)
        {
            Pbx.Image = Comun.ObtenerRecurso($"trasera{(int)nivel}");
            Activable = activable;
            Estado = EstadoCarta.Trasera;
            Tag = nivel.ToString();
            TtAyuda.SetToolTip(Pbx, "");
            SetIcono(IconChar.None, "");
        }

        /// <summary>
        /// Obtiene el nivel de desarrollo de una carta trasera
        /// </summary>
        /// <returns></returns>
        public NivelDesarrollo Nivel()
        {
            if (!Estado.Equals(EstadoCarta.Trasera))
                throw new Exception($"No se puede obtener el nivel en el estado {Estado.ToString()}");
            return (NivelDesarrollo)Enum.Parse(typeof(NivelDesarrollo), Tag.ToString());
        }
        
        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);

        public void SetIcono(IconChar icon, string texto)
        {
            if (Estado == EstadoCarta.Desarrollo)
            {
                PbxHelp.IconChar = icon;
                PbxHelp.Visible = !icon.Equals(IconChar.None);
                ToolTipAyuda.SetToolTip(PbxHelp, texto);
            }
            else PbxHelp.Visible = false;
        }
    }
}
