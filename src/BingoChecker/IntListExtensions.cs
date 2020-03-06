using System.Collections.Generic;
using System.Text;

namespace BingoChecker
{
    public static class IntListExtensions
    {
        public static string ListOutNumbers(this IEnumerable<int> list)
        {
            return new StringBuilder().AppendJoin(", ", list).ToString();
        }
    }
}
