﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Splendor.Forms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.MainView());
            //Application.Run(new Views.TestView());
        }
    }
}