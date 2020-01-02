using System.Drawing;

namespace Splendor.Domain
{
    public class ColorGroup
    {
        public PlayingColor PlayingColor { get; }
        public Color StrongColor { get; }
        public Color SoftColor { get; }

        public ColorGroup(PlayingColor playingColor, Color strongColor, Color softColor)
        {
            PlayingColor = playingColor;
            StrongColor = strongColor;
            SoftColor = softColor;
        }
    }
}
