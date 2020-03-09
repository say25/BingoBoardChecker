using System.Collections.Generic;

namespace BingoChecker.Boards
{
    public class Board0 : IBoard
    {
        public IList<int> GetNumbers() => Numbers;

        public static readonly IList<int> Numbers = new List<int>
        {
            01,
            02,
            03,
            04,
            05,
            06,
            07,
            08,
            09,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
        };
    }
}
