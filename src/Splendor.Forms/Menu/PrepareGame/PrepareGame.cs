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
    public partial class PrepareGame : BaseUserControl
    {
        public event EventHandler OnBackButtonClicked;
        public event EventHandler<PlayGameEventArgs> OnPlayButtonClicked;

        public PrepareGame()
        {
            InitializeComponent();

            Face1.Avatar = Configuration.DefaultAvatar;
            Face1.Color = Configuration.DefaultColorGroup;
            Face1.SetPlayerName("Jorge");

            Face2.Avatar = Avatars.GetRandomAvatar();
            Face2.Color = ColorFactory.GetRandomColor(Face1.Color);
            Face2.SetPlayerName(Face2.Avatar.ToString());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new PlayGameEventArgs(GetPrestige(), GetPlayers());
            OnPlayButtonClicked?.Invoke(this, eventArgs);
        }

        private Prestige GetPrestige() => Prestige.FromScalar(ObjetiveSelector.CurrentValue);

        private IEnumerable<(Avatar avatar, ColorGroup color)> GetPlayers()
        {
            yield return (Face1.Avatar, Face1.Color);
            yield return (Face2.Avatar, Face2.Color);

        }
    }
}
