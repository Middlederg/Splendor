using System;
using System.Linq;
using System.Reflection;

namespace System
{
    public class DisplayAttribute : Attribute
    {
        public string Name { get; set; }
    }

    public static class DisplayAttributeHelper
    {
        public static string DisplayName<TEnum>(this TEnum source) where TEnum : Enum
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DisplayAttribute[] attributes = (DisplayAttribute[])fi.GetCustomAttributes(
                typeof(DisplayAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Name;
            return source.ToString();
        }
    }
}
