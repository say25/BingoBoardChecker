using System.Collections.Generic;

namespace BingoChecker
{
    internal interface IBoard<T>
    {
        IList<T> GetNumbers();
    }
}
