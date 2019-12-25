using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Splendor.Forms
{
    public static class Configuration
    {
        public static Color Primary = Color.SlateBlue;
        public static Color Secondary = Color.DeepSkyBlue;
        public static Color Terciary = Color.BurlyWood;

        public static int DefaultProfile = 1;
        public static WaitTimes DefaultWaitTime = WaitTimes.Standard;

        public static int GetWaitTime = waitTimes[(int)DefaultWaitTime];
        private static int[] waitTimes = new int[] { 500, 1000, 2000, 3000, 5000 };

        public static int CardWidth = 119;
        public static int CardHeight = 166;

        public static Color SelectionColor = Color.SlateBlue; //burlywood
    }
}
