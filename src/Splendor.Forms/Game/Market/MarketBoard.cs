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
    public partial class MarketBoard : BaseUserControl
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
            Diamond.Gem = Gems.Diamond;
            Ruby.Gem = Gems.Ruby;
            Onyx.Gem = Gems.Onyx;
            Sapphire.Gem = Gems.Sapphire;
            Emerald.Gem = Gems.Emerald;
            Gold.Gem = Gems.Gold;
        }

        public void AddGem(Gem gem)
        {
            Flp.Controls.OfType<GemToken>()
                .FirstOrDefault(x => x.Gem == gem)?
                .AddGem();
        }

        public void Draw()
        {
            foreach (var token in Flp.Controls.OfType<GemToken>())
            {
                token.SetGems(token.Gem.Get(market.AvaliableOfType(token.Gem)).ToArray());
                token.Draw();
            }
        }

        private void GemaClick(object sender, EventArgs e)
        {
            if (sender is GemToken token && token.SubIndex > 0)
            {
                token.RemoveGems(token.Gem);
                OnGemSelected?.Invoke(sender, new GemEventArgs(token.Gem));
            }
        }
    }
}
