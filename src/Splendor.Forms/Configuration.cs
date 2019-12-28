using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Splendor.Forms
{
    public sealed class Configuration : Singleton
    {
        public const int CardWidth = 119;
        public const int CardHeight = 166;

        public static int DefaultLanguage = Properties.Settings.Default.DefaultLanguage;
        public static Color PrimaryColor = Properties.Settings.Default.PrimaryColor;
        public static Color SecondaryColor = Properties.Settings.Default.SecondaryColor;
        public static Color TerciaryColor = Properties.Settings.Default.TerciaryColor;
        public static int DefaultProfile = Properties.Settings.Default.DefaultProfile;
        private static readonly int DefaultWaitTimeIndex = Properties.Settings.Default.DefaultWaitTime;
        public static WaitTimes DefaultWaitTime = Enum.GetValues(typeof(WaitTimes)).Cast<WaitTimes>().ElementAt(DefaultWaitTimeIndex);

        public Configuration()
        {
            Constants.CurrentLanguage = (Language)DefaultLanguage;
        }
    }
}
