using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class DevelopmentList : BaseForm
    {
        private IEnumerable<Development> developments;
        public IEnumerable<Development> Developments
        {
            get => developments;
            set
            {
                Text = developments.JoinList();
                developments = value;
                if (value != null)
                {
                    foreach (var development in value)
                    {
                        var card = new Card()
                        {
                            Development = development,
                            Status = CardStatus.FaceUp,
                            Activable = false
                        };
                        card.Draw();
                        Flp.Controls.Add(card);
                    }
                }
            }
        }

        public DevelopmentList()
        {
            InitializeComponent();
        }
    }
}
