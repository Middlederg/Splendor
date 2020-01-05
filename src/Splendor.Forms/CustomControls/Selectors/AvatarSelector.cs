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
    public partial class AvatarSelector : BaseUserControl
    {
        public event EventHandler<ValueEventArgs<Avatar>> OnAvatarChanged;

        private readonly List<Avatar> avatars = Avatars.GetAll().ToList();

        private int currentIndex;
        public int CurrentIndex 
        {
            get => currentIndex;
            set
            {
                currentIndex = value;
                SetAvatar();
            }
        }
        public Avatar CurrentAvatar
        {
            get => avatars[currentIndex];
            set => CurrentIndex = avatars.IndexOf(value);
        }

        public AvatarSelector()
        {
            InitializeComponent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                CurrentIndex--;
            }
            else
            {
                CurrentIndex = avatars.Count - 1;
            }
            OnAvatarChanged?.Invoke(this, new ValueEventArgs<Avatar>(avatars[currentIndex]));
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < avatars.Count() - 1)
            {
                CurrentIndex++;
            }
            else
            {
                CurrentIndex = 0;
            }
            OnAvatarChanged?.Invoke(this, new ValueEventArgs<Avatar>(avatars[currentIndex]));
        }

        private void SetAvatar()
        {
            Picture.BackgroundImage = avatars[currentIndex].GetImage();
        }

        private void UpButton_Click_1(object sender, EventArgs e)
        {

        }

        private void DownButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
