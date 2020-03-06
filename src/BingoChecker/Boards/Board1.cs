using System.Collections.Generic;

namespace BingoChecker.Boards
{
    public class Board1 : IBoard
    {
        public IList<int> GetNumbers()
        {
            return Numbers;
        }

        public static readonly IList<int> Numbers = new List<int>
        {
            14,
            23,
            40,
            49,
            73,
            03,
            21,
            36,
            56,
            61,
            08,
            19,
            -1,
            60,
            72,
            02,
            18,
            41,
            47,
            66,
            05,
            30,
            44,
            50,
            70,
        };
    }
}
