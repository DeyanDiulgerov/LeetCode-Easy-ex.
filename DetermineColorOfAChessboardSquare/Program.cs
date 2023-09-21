using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineColorOfAChessboardSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetermineColorOfAChessboardSquare("a1"));
            Console.WriteLine(DetermineColorOfAChessboardSquare("h3"));
            Console.WriteLine(DetermineColorOfAChessboardSquare("c7"));
        }

        public static bool DetermineColorOfAChessboardSquare(string coordinates)
        {
            int letter = coordinates[0] - 'a';
            int digit = coordinates[1] - '0';
            return (letter + digit) % 2 == 0;
        }
    }
}
