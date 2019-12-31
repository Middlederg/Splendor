using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class LogView : BaseForm
    {
        private readonly Log log;

        public LogView(Log log)
        {
            InitializeComponent();
            this.log = log;
            SetText("Log");
            FillListView();
        }

        private void FillListView()
        {
            foreach (var entry in log.Entries)
            {
                var item = new ListViewItem(entry.Turn.ToString());
                item.SubItems.Add(entry.Player.ToString());
                item.SubItems.Add(entry.Move.ToString());
                Lvw.Items.Add(item);
            }
        }
    }
}
