using System.Collections.Generic;

namespace BingoChecker.Boards
{
    public class Board3 : IBoard
    {
        public IList<int> GetNumbers()
        {
            return Numbers;
        }

        public static readonly IList<int> Numbers = new List<int>
        {
            02,
            27,
            32,
            05,
            64,
            13,
            22,
            38,
            49,
            75,
            04,
            30,
            -1,
            55,
            74,
            05,
            24,
            36,
            52,
            66,
            12,
            26,
            41,
            47,
            62,
        };
    }
}
