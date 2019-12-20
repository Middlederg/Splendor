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
    public partial class UcCuadroValores : UcBase
    {
        private IEnumerable<UcRecurso> GetRecursos => new List<UcRecurso>() { ucRecurso1, ucRecurso2, ucRecurso3, ucRecurso4, ucRecurso5 };

        public UcCuadroValores() { InitializeComponent(); }
        public UcCuadroValores(Juego juego, int idJugador)
        {
            InitializeComponent();
        }

        public void Actualizar(Jugador jugador)
        {
            foreach (var recurso in GetRecursos)
            {
                recurso.NumeroGemas = jugador.TotalGemas(recurso.TipoGema);
                recurso.NumeroDesarrollos = jugador.Bonificacion(recurso.TipoGema);
            }
            Oro.Numero = jugador.TotalGemas(Gema.Oro);
            LblNumGemas.Text = $"{jugador.TotalGemas()}/10";
        }
    }
}
