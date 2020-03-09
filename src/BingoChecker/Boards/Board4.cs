using System.Collections.Generic;

namespace BingoChecker.Boards
{
    public class Board4 : IBoard<int>
    {
        public IList<int> GetNumbers() => Numbers;

        private static readonly IList<int> Numbers = new List<int>
        {
            11,
            20,
            42,
            57,
            61,
            08,
            28,
            41,
            47,
            65,
            15,
            16,
            -1,
            48,
            67,
            10,
            27,
            37,
            60,
            63,
            09,
            24,
            35,
            52,
            74,
        };
    }
}
