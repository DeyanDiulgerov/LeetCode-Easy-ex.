using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDistinctNumbersOnBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountDistinctNumbersOnBoard(5));
            Console.WriteLine(CountDistinctNumbersOnBoard(3));
            Console.WriteLine(CountDistinctNumbersOnBoard(1));
        }

        public static int CountDistinctNumbersOnBoard(int n)
        {
            return n == 1 ? 1 : n - 1;
        }
    }
}
