using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Splendor.Core
{
    public static class Comun
    {
        public static Image GetImage(string path)
        {
            var file = Domain.Properties.Resources.ResourceManager.GetObject(path) as byte[];
            if (file != null)
            {
                using (var ms = new MemoryStream(file))
                {
                    return new Bitmap(ms);
                }
            }
            return null;
        }

        public static Icon GetIcon(string path)
        {
            var file = Domain.Properties.Resources.ResourceManager.GetObject(path) as byte[];
            using (var ms = new MemoryStream(file))
            {
                return new Icon(ms);
            }
        }
    }
}
