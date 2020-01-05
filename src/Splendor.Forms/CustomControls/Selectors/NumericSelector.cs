using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class NumericSelector : BaseUserControl
    {
        public event EventHandler<ValueEventArgs<int>> OnValueChangedClicked;

        private int currentValue;
        public int CurrentValue 
        {
            get => currentValue;
            set
            {
                if (value < MinValue)
                    throw new ArgumentOutOfRangeException($"{value} must be a number higher than {MinValue}");

                if (value > MaxValue)
                    throw new ArgumentOutOfRangeException($"{value} must be a number lower than {MaxValue}");

                currentValue = value;
                DownButton.Enabled = currentValue > MinValue;
                UpButton.Enabled = currentValue < MaxValue;
                MainLabel.Text = currentValue.ToString();
            }
        }

        private int minValue = 0;
        public int MinValue
        {
            get => minValue;
            set
            {
                if (value > currentValue)
                    throw new ArgumentOutOfRangeException($"Min value {value} can not be be a number highr than current value {currentValue}");

                minValue = value;
            }
        }

        private int maxValue = 100;
        public int MaxValue
        {
            get => maxValue;
            set
            {
                if (value < currentValue)
                    throw new ArgumentOutOfRangeException($"Max value {value} can not be be a number lower than current value {currentValue}");

                maxValue = value;
            }
        }

        public NumericSelector()
        {
            InitializeComponent();
            DownButton.Enabled = false;
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if(currentValue - 1 >= MinValue)
            {
                CurrentValue -= 1;
                OnValueChangedClicked?.Invoke(this, new ValueEventArgs<int>(currentValue));
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (currentValue + 1 <= MaxValue)
            {
                CurrentValue -= 1;
                OnValueChangedClicked?.Invoke(this, new ValueEventArgs<int>(currentValue));
            }
        }
    }

  
}
