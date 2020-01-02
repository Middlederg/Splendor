using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class ResourceControl : BaseUserControl
    {
        public IEnumerable<Gem> Gems
        {
            get => GemCounter.Gems;
            set => GemCounter.Gems = value;
        }

        public IEnumerable<Development> Developments
        {
            get => DevelopmentCounter.Developments;
            set => DevelopmentCounter.Developments = value;
        }

        public ResourceControl()
        {
            InitializeComponent();
        }
    }
}
