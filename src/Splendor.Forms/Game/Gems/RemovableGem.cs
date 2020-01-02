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
    public partial class RemovableGem : BaseUserControl
    {
        public event EventHandler<GemEventArgs> OnGemRemoveClicked;

        public Gem Gem { get; set; }
        public void Draw()
        {
            if (Gem != null)
            {
                Pbx.Image = Gem.GetImage();
                ToolTipAyuda.SetToolTip(Pbx, Gem.ToString());
            }
            else
            {
                Pbx.Image = null;
                ToolTipAyuda.SetToolTip(Pbx, "");
            }
        }

        [DefaultValue(false)]
        public bool Removable
        {
            get => RemoveButton.Visible;
            set => RemoveButton.Visible = value;
        }

        public RemovableGem()
        {
            InitializeComponent();
        }

        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Removable)
            {
                OnGemRemoveClicked?.Invoke(this, new GemEventArgs(Gem));
            }
        }
    }
}
