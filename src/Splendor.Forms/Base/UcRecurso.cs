using Splendor.Domain;
using Splendor.Forms.CustomControls;
using Splendor.Forms.Model;
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
        [Description("Fuente de los desarrollos")]
        public Font FuenteDesarrollo
        {
            get => Desarrollos.Fuente;
            set => Desarrollos.Fuente = value;
        }

        [Description("Fuente de las gemas")]
        public Font FuenteGemas
        {
            get => Gemas.Fuente;
            set => Gemas.Fuente = value;
        }

        [Description("Número de gemas")]
        public int NumeroGemas
        {
            get => Gemas.Numero;
            set => Gemas.Numero = value;
        }

        [Description("Gema asociada")]
        public Gem TipoGema
        {
            get => Gemas.Gem;
            set
            {
                Gemas.Gem = value;
                pGeneral.BackColor = value.BackColor();
            }
        }

        [Description("Número de desarrollos de ese tipo de gema")]
        public int NumeroDesarrollos
        {
            get => Desarrollos.Numero;
            set => Desarrollos.Numero = value;
        }

        public UcRecurso()
        {
            InitializeComponent();
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = SmoothingMode.AntiAlias;
        //    int distancia = 4;
        //    g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.Red, 0.00f)), distancia / 2, distancia / 2, Width - distancia, Height - distancia, 8);
        //}
    }
}
