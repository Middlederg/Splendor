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
    public partial class MarketBoard : UcBase
    {
        private Market market;
        public Market Market
        {
            get => market;
            set
            {
                market = value;
                if (market != null)
                {
                    market.Subscribe(Draw);
                }
            }
        }

        public event EventHandler<GemEventArgs> OnGemSelected;

        public MarketBoard()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            foreach (var token in Flp.Controls.OfType<GemToken>())
            {
                token.AddGems(token.Gem.Get(market.AvaliableOfType(token.Gem)).ToArray());
            }
        }

        private void GemaClick(object sender, EventArgs e)
        {
            if (sender is GemToken token && token.SubIndex > 0)
            {
                token.AddGems(token.Gem);
                OnGemSelected?.Invoke(sender, new GemEventArgs(token.Gem));
            }
        }
    }
}
