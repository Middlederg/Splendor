using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Splendor.Core
{
    public static class Comun
    {
        public static Image ObtenerRecurso(string nombre) => (Image)Properties.Resources.ResourceManager.GetObject(nombre);
    }
}
