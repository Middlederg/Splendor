using Splendor.Domain;
using Splendor.Forms.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms.UserControls
{
    public partial class UcAccion : UcBase
    {
        public UcAccion()
        {
            InitializeComponent();
        }
        public UcAccion(IAccion accion, EventHandler onClose)
        {
            InitializeComponent();

            //Añado los recursos al panel
            foreach (var r in accion.RecursosCogidos())
            {
                Flp.Controls.Add(new PictureBox()
                {
                    Image = new NamedPath(r).GetImage(),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(10)
                });
            }

            //Añado el boton al panel
            var btn = new CustomButtonOk()
            {
                Text = "",
                Dock = DockStyle.Fill,
                Margin = new Padding(10),
            };
            btn.Click += onClose;
            Flp.Controls.Add(btn);
        }


    }
}
