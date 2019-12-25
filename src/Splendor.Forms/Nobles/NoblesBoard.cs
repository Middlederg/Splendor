using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class NoblesBoard : UserControl
    {
        private NobilityBox nobilitybox;
        public NobilityBox NobilityBox
        {
            get => nobilitybox;
            set
            {
                nobilitybox = value;
                if (nobilitybox != null)
                {
                    nobilitybox.Subscribe(Draw);
                }
            }
        }

        public NoblesBoard()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            foreach (var uc in Flp.Controls.OfType<NobleTile>())
            {
                uc.Noble = null;
            }
                
            for (int i = 0; i < nobilitybox.RemainigNobles; i++)
            {
                var noble = nobilitybox.NobleList[i];
                (Flp.Controls[i] as NobleTile).Noble = noble;
            }
        }

        //private void AnchoNobles() => Height = j.Nobles.Count * 155;
        
    }
}
