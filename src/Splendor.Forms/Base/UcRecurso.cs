using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class UcRecurso : UcBase
    {
        public Font FuenteDesarrollo
        {
            get => Desarrollos.Fuente;
            set => Desarrollos.Fuente = value;
        }

        public Font FuenteGemas
        {
            get => Gemas.Fuente;
            set => Gemas.Fuente = value;
        }

        public int NumeroGemas
        {
            get => Gemas.Numero;
            set => Gemas.Numero = value;
        }

        public Gem TipoGema
        {
            get => Gemas.Gem;
            set
            {
                Gemas.Gem = value;
                pGeneral.BackColor = value.BackColor();
            }
        }

        public int NumeroDesarrollos
        {
            get => Desarrollos.Numero;
            set => Desarrollos.Numero = value;
        }

        public UcRecurso()
        {
            InitializeComponent();
        }
    }
}
