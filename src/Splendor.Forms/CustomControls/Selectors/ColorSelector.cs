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
    public partial class ColorSelector : BaseUserControl
    {
        public event EventHandler<ValueEventArgs<ColorGroup>> OnColorChanged;

        private readonly List<ColorGroup> colors = ColorFactory.Colors;
        private readonly int colorLastIndex = Enum.GetValues(typeof(PlayingColor)).Length - 1;

        private PlayingColor currentColor;
        public PlayingColor CurrentColor
        {
            get => currentColor;
            set
            {
                currentColor = value;
                SetColor();
            }
        }

        public ColorSelector()
        {
            InitializeComponent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            int index = (int)currentColor;
            if (index > 0)
            {
                CurrentColor = (PlayingColor)(index - 1);
            }
            else
            {
                CurrentColor = (PlayingColor)colorLastIndex;
            }
            OnColorChanged?.Invoke(this, new ValueEventArgs<ColorGroup>(colors[(int)currentColor]));
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            int index = (int)currentColor;
            if (index < colorLastIndex)
            {
                CurrentColor = (PlayingColor)(index + 1);
            }
            else
            {
                CurrentColor = PlayingColor.DefaultBlue;
            }
            OnColorChanged?.Invoke(this, new ValueEventArgs<ColorGroup>(colors[(int)currentColor]));
        }

        private void SetColor()
        {
            SoftLabel.BackColor = colors[(int)currentColor].SoftColor;
            StrongLabel.BackColor = colors[(int)currentColor].StrongColor;
            StrongLabel.Text = currentColor.ToString();
        }
    }
}
