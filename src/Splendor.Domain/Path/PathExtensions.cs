using System.Drawing;
using System.IO;

namespace Splendor.Domain
{
    public static class PathExtensions
    {
        public static Image GetImage(this IPath item)
        {
            if (item != null)
            {
                var file = Domain.Properties.Resources.ResourceManager.GetObject(item.Path) as byte[];
                if (file != null)
                {
                    using (var ms = new MemoryStream(file))
                    {
                        return new Bitmap(ms);
                    }
                }
            }
            return null;
        }

        public static Icon GetIcon(this IPath item)
        {
            var file = Domain.Properties.Resources.ResourceManager.GetObject(item.Path) as byte[];
            using (var ms = new MemoryStream(file))
            {
                return new Icon(ms);
            }
        }
    }
}
