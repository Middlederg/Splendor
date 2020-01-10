using System;
using System.Linq;

namespace System
{
    public class DisplayAttribute : Attribute
    {
        public string Name { get; }

        public DisplayAttribute(string name)
        {
            Name = name;
        }
    }
}
