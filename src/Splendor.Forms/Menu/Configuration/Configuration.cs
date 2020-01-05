using Splendor.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Splendor.Forms
{
    public sealed class Configuration : Singleton
    {
        public const int CardWidth = 119;
        public const int CardHeight = 166;

        public static int DefaultLanguage = Properties.Settings.Default.DefaultLanguage;
        public static Color SelectionColor = Properties.Settings.Default.SelectionColor;
        public static int DefaultIdAvatar = Properties.Settings.Default.DefaultAvatar;
        public static Avatar DefaultAvatar = Avatars.GetById(DefaultIdAvatar);
        public static int DefaultColor = Properties.Settings.Default.DefaultColor;
        public static ColorGroup DefaultColorGroup = ColorFactory.GetColor((PlayingColor)DefaultColor);

        private static readonly int DefaultWaitTimeIndex = Properties.Settings.Default.DefaultWaitTime;
        public static WaitTimes DefaultWaitTime = Enum.GetValues(typeof(WaitTimes)).Cast<WaitTimes>().ElementAt(DefaultWaitTimeIndex);

        public Configuration()
        {
            Constants.CurrentLanguage = (Language)DefaultLanguage;
        }

        public static void SetDefaultAvatar(int idAvatar) => Properties.Settings.Default.DefaultAvatar = idAvatar;
        public static void SetDefaultLanguage(int language) => Properties.Settings.Default.DefaultLanguage = language;
        public static void SetDefaultColor(int color) => Properties.Settings.Default.DefaultColor = color;
        public static void SetDefaultWaitTime(int waitTime) => Properties.Settings.Default.DefaultWaitTime = waitTime;

        public static string CurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return $"v{assembly.GetName().Version.ToString(3)}";
        }
    }
}
