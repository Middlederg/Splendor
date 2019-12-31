using System.Drawing;

namespace Splendor.Domain
{
    public class PlayerColor
    {
        public Color StrongColor { get; }
        public Color SoftColor { get; }

        public PlayerColor(Color strongColor, Color softColor)
        {
            StrongColor = strongColor;
            SoftColor = softColor;
        }
    }
}
