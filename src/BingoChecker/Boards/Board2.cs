using System.Collections.Generic;

namespace BingoChecker.Boards
{
    public class Board2 : IBoard<int>
    {
        public IList<int> GetNumbers() => Numbers;

        private static readonly IList<int> Numbers = new List<int>
        {
            09,
            22,
            35,
            55,
            75,
            12,
            28,
            33,
            48,
            69,
            11,
            25,
            -1,
            53,
            63,
            15,
            16,
            39,
            51,
            62,
            07,
            27,
            34,
            59,
            67,
        };
    }
}
