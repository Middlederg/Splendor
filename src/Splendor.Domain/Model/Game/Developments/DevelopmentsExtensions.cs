using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Splendor.Domain
{
    public static class DevelopmentsExtensions
    {
        public static string JoinList(this IEnumerable<Development> developments)
        {
            var quantity = developments.Count();
            string bonus = (developments.Select(x => x.Bonus).Distinct().Count() == 1) ? $" ({developments.First().Bonus.ToString()})" : "";
            return $"{quantity} {(quantity == 1 ? Development.Singular() : Development.Plural())}{bonus}";
        }      

        public static Color BackColor(this IEnumerable<Development> developments)
        {
            if (!developments.AllSameBonus())
                return Color.Transparent;
            return developments.First().Bonus.Color;
        }

        public static bool AllSameBonus(this IEnumerable<Development> developments)
        {
            if (!developments.Any())
                return false;

            return developments.Select(x => x.Bonus).AllSame();
        }
    }
}
