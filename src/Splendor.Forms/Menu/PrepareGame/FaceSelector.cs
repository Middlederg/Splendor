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
    public partial class FaceSelector : BaseUserControl
    {
        public event EventHandler OnPlayerActivated;
        public event EventHandler OnPlayerDeactivated;

        public bool PlayerSelected => Face.Visible;

        public Avatar Avatar 
        {
            get => Face.Avatar;
            set => Face.Avatar = value; 
        }

        public ColorGroup Color
        {
            get => Face.Color;
            set => Face.Color = value;
        }

        public FaceSelector()
        {
            InitializeComponent();

            Face.OnFaceRemoved += FaceRemoveClicked;
            FaceRemoveClicked(null, EventArgs.Empty);
        }

        private void FaceRemoveClicked(object sender, EventArgs e)
        {
            MainTable.ColumnStyles[0].Width = 100;
            MainTable.ColumnStyles[1].Width = 0;
            AddButton.Size = new Size(110, 110);
            Face.Visible = false;
            AddButton.Visible = true;
            OnPlayerDeactivated?.Invoke(this, EventArgs.Empty);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainTable.ColumnStyles[0].Width = 0;
            MainTable.ColumnStyles[1].Width = 100;
            Face.Size = new Size(130, 130);
            Face.Visible = true;
            AddButton.Visible = false;
            OnPlayerActivated?.Invoke(this, EventArgs.Empty);
        }
    }
}
