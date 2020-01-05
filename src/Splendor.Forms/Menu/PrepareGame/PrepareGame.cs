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

            FaceSelector3.OnPlayerActivated += OnPlayer3Activated;
            FaceSelector3.OnPlayerDeactivated += OnPlayer3Deactivated;
            FaceSelector4.OnPlayerActivated += OnPlayer4Activated;
            FaceSelector4.OnPlayerDeactivated += OnPlayer4Deactivated;
            InitializePlayers();
        }

        private void OnPlayer3Activated(object sender, EventArgs e) => IA3.Visible = true;
        private void OnPlayer3Deactivated(object sender, EventArgs e) => IA3.Visible = false;
        private void OnPlayer4Activated(object sender, EventArgs e) => IA4.Visible = true;
        private void OnPlayer4Deactivated(object sender, EventArgs e) => IA4.Visible = false;

        private void InitializePlayers()
        {
            Face1.Avatar = Configuration.DefaultAvatar;
            Face1.Color = Configuration.DefaultColorGroup;
            Face1.SetPlayerName("Jorge");

            Face2.Avatar = Avatars.GetRandomAvatar();
            Face2.Color = ColorFactory.GetRandomColor(Face1.Color);

            FaceSelector3.Avatar = Avatars.GetRandomAvatar();
            FaceSelector3.Color = ColorFactory.GetRandomColor(Face1.Color, Face2.Color);

            FaceSelector4.Avatar = Avatars.GetRandomAvatar();
            FaceSelector4.Color = ColorFactory.GetRandomColor(Face1.Color, Face2.Color, FaceSelector3.Color);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InitializePlayers();
            OnBackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new PlayGameEventArgs(GetPrestige(), GetPlayers().ToList());
            OnPlayButtonClicked?.Invoke(this, eventArgs);
        }

        private Prestige GetPrestige() => Prestige.FromScalar(ObjetiveSelector.CurrentValue);

        private IEnumerable<(Avatar avatar, ColorGroup color)> GetPlayers()
        {
            yield return (Face1.Avatar, Face1.Color);
            yield return (Face2.Avatar, Face2.Color);

            if (FaceSelector3.PlayerSelected)
                yield return (FaceSelector3.Avatar, FaceSelector3.Color);

            if (FaceSelector4.PlayerSelected)
                yield return (FaceSelector4.Avatar, FaceSelector4.Color);
        }
    }
}
