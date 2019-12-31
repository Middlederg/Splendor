using System;
using System.Drawing;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public interface IGameActionView : IDisposable
    {
        Point Location { get; set; }
        FormStartPosition StartPosition { get; set; }

        DialogResult ShowDialog();
    }
}
