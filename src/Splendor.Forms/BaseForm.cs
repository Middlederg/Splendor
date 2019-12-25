using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class BaseForm : Form
    {
        public void SetText(string value)
        {
            Title.Text = value;
            Text = value;
        }

        public IconChar WindowIcon
        {
            get => IconPicture.IconChar;
            set => IconPicture.IconChar = value;
        }

        public bool CloseEnabled 
        {
            get => CloseButton.Visible;
            set => CloseButton.Visible = value;
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            if (CloseEnabled)
            {
                Close();
            }
        }

        #region MoveForm

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveFormMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
    }
}
