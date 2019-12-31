using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class GemPile : GemToken
    {
        public GemPile()
        {
            InitializeComponent();
        }

        protected override IPath Path => Gem.PilePath(SubIndex);
    }
}
