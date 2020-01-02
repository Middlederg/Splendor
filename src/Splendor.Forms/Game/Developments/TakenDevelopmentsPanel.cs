using Splendor.Domain;
using Splendor.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class TakenDevelopmentsPanel : BaseUserControl
    {
        public event EventHandler<DevelopmentEventArgs> OnDevelopmentBought;
        public event EventHandler<DevelopmentEventArgs> OnDevelopmentReserved;

        public Player CurrentPlayer { get; set; }
        public Market Market { get; set; }

        private Development development;
        public Development Development
        {
            get => development;
            set
            {
                Visible = true;
                development = value;
                var purchaseService = new PurchaseService(development, CurrentPlayer);
                BuyButton.Enabled = purchaseService.CanAfford();
                ToolTipAyuda.SetToolTip(BuyButton, purchaseService.ToString());

                var reserveService = new ReserveService(development, CurrentPlayer, Market);
                ReserveButton.Enabled = reserveService.CanReserve();
                ToolTipAyuda.SetToolTip(ReserveButton, reserveService.ToString());
            }
        }
        public TakenDevelopmentsPanel()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            development = null;
            ToolTipAyuda.SetToolTip(BuyButton, "");
            ToolTipAyuda.SetToolTip(ReserveButton, "");
        }

        private void BuyButtonClick(object sender, EventArgs e)
        {
            OnDevelopmentBought?.Invoke(this, new DevelopmentEventArgs(development));
            Visible = false;
        }

        private void ReserveButtonClick(object sender, EventArgs e)
        {
            OnDevelopmentReserved?.Invoke(this, new DevelopmentEventArgs(development));
            Visible = false;
        }
    }
}
