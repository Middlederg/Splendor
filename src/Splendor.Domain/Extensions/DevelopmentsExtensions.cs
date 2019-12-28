using System.Collections.Generic;
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
    }
}
