using Splendor.Domain;
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
    public partial class TakenGemsPanel : UcBase
    {
        public Player CurrentPlayer { get; set; }
        public Market Market { get; set; }

        public event EventHandler<GemEventArgs> OnGemHasBeenRemoved;
        public event EventHandler OnTransactionCompleted;

        public IEnumerable<Gem> GetSelectedGems() => FlpContainer.Controls
            .OfType<RemovableGem>()
            .Select(x => x.Gem)
            .ToList();

        public TakenGemsPanel()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            FlpContainer.Controls.Clear();
            BtnOk.Visible = false;
            FlpContainer.Controls.Clear();
        }

        public void AddGem(Gem gem)
        {
            var removableGem = new RemovableGem()
            {
                Gem = gem,
                Removable = true,
                Size = new Size(70, 70)
            };
            removableGem.Draw();
            removableGem.OnGemRemoveClicked += RemoveGem;
            FlpContainer.Controls.Add(removableGem);
            UpdateOkButton();
        }

        private void RemoveGem(object sender, EventArgs e)
        {
            if (sender is RemovableGem removableGem)
            {
                FlpContainer.Controls.Remove(removableGem);
                UpdateOkButton();
                OnGemHasBeenRemoved(this, new GemEventArgs(removableGem.Gem));
            }
        }


        //public bool Anexable(Gem gema)
        //{
        //    if (GemasSeleccionadas.Count == 3) return false;
        //    if (GemasSeleccionadas.Count == 2 && GemasSeleccionadas.Contains(gema)) return false;
        //    if (GemasSeleccionadas.Contains(gema) && !j.PuedeCogerDosGemas(gema)) return false;
        //    return true;
        //}

        private void UpdateOkButton()
        {
            var gems = GetSelectedGems().ToList();
            var service = new TakeGemsService(CurrentPlayer, Market, gems.ToArray());
            BtnOk.Visible = service.CanBeTaken();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            OnTransactionCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
