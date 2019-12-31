using System.Drawing;

namespace Splendor.Domain
{
    public static class PlayerColorFactory
    {
        public static PlayerColor Default => new PlayerColor(Color.SlateBlue, Color.DeepSkyBlue);
        public static PlayerColor Red => new PlayerColor(Color.IndianRed, Color.LightCoral);
        public static PlayerColor Green => new PlayerColor(Color.DarkOliveGreen, Color.LightGreen);
        public static PlayerColor Gray => new PlayerColor(Color.DarkGray, Color.LightGray);
        public static PlayerColor Orange => new PlayerColor(Color.DarkOrange, Color.OldLace);
    }
}
