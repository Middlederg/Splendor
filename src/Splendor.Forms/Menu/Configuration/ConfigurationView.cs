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
    public partial class ConfigurationView : BaseUserControl
    {
        public event EventHandler OnBackButtonClicked;

        public ConfigurationView()
        {
            InitializeComponent();

            foreach (var language in Enum.GetValues(typeof(Language)).OfType<Language>())
            {
                ComboLanguage.Items.Add(language.DisplayName());
            }
            ComboLanguage.SelectedIndex = Configuration.DefaultLanguage;

            var currentAvatarId = Configuration.DefaultIdAvatar;
            var avatarIndex = Avatars.GetAll().ToList().IndexOf(Avatars.GetById(currentAvatarId));
            DefaultAvatarSelector.CurrentIndex = avatarIndex;

            var color = (PlayingColor)Configuration.DefaultColor;
            DefaultColorSelector.CurrentColor = color;

            DefaultColorSelector.OnColorChanged += ColorChanged;
            DefaultAvatarSelector.OnAvatarChanged += AvatarChanged;

            var waitTimes = Enum.GetValues(typeof(WaitTimes)).OfType<WaitTimes>().ToList();
            WaitTimeTrackBar.Maximum = waitTimes.Count() - 1;
            WaitTimeTrackBar.Value = waitTimes.IndexOf(Configuration.DefaultWaitTime);
            ToolTipAyuda.SetToolTip(WaitTimeTrackBar, Configuration.DefaultWaitTime.DisplayName());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ComboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboLanguage.SelectedIndex != -1)
            {
                Configuration.SetDefaultLanguage(ComboLanguage.SelectedIndex);
                Properties.Settings.Default.Save();
            }
        }

        private void AvatarChanged(object sender, ValueEventArgs<Avatar> e)
        {
            Configuration.SetDefaultAvatar(e.Value.Id);
            Properties.Settings.Default.Save();
        }

        private void ColorChanged(object sender, ValueEventArgs<ColorGroup> e)
        {
            Configuration.SetDefaultColor((int)e.Value.PlayingColor);
            Properties.Settings.Default.Save();
        }

        private void WaitTimeTrackBar_Scroll(object sender, EventArgs e)
        {
            if (WaitTimeTrackBar.Value != -1)
            {
                Configuration.SetDefaultWaitTime(WaitTimeTrackBar.Value);
                Properties.Settings.Default.Save();
                ToolTipAyuda.SetToolTip(WaitTimeTrackBar, Configuration.DefaultWaitTime.DisplayName());
            }
        }
    }
}
