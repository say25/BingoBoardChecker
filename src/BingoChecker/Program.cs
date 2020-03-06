using System;
using System.Collections.Generic;
using System.Linq;
using BingoChecker.Boards;

namespace BingoChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, Let Me Check Your Bingo Boards!");

            var boards = new List<IBoard> { new Board1(), new Board2(), new Board3(), new Board4(), };

            var i = 1;
            
            foreach (var board in boards)
            {
                var numbers = board.GetNumbers();
                var matches = ReadNumbers.Intersect(numbers).ToList();

                Console.WriteLine($"Board {i} - Matches {matches.Count}");

                Console.WriteLine($"Matches: {matches.ListOutNumbers()}");

                if (matches.Count >= 24)
                {
                    Console.WriteLine($"I think you have a BINGO on Board {i}");
                }

                i++;
            }

            Console.WriteLine("Checked Your Boards");
        }

        private static readonly IList<int> ReadNumbers = new List<int>
        {
            // DAY1
            60,
            19,
            17,
            01,
            // DAY2
            65,
            47,
            69, 
            68,
            // DAY3
            38,
            62,
            06,
            73,
            // DAY4
            54, 
            63,
            33,
            40,
            // DAY5
            56,
            31,
            20,
            42,
        };
    }
}
