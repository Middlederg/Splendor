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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var group = (ColorGroup)obj;
            return group.PlayingColor == PlayingColor;
        }

        public override int GetHashCode() => PlayingColor.GetHashCode();
    }
}
