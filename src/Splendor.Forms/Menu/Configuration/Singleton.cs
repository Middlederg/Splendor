using System;

namespace Splendor.Forms
{
    public class Singleton
    {
        private static readonly Lazy<Configuration> lazy = new Lazy<Configuration>(() => new Configuration());

        protected static Configuration Instance => lazy.Value;
        protected Singleton() { }
    }
}
