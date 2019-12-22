using System.Collections.Generic;

namespace Splendor.Domain
{
    public static class StringExtensions
    {
        public static string JoinList(this IEnumerable<string> list, string separator = ", ") => string.Join(separator, list);
    }
}
