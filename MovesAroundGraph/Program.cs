using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovesAroundGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nNumber of Moves Around Graph 3 : 3");
            Console.WriteLine(MovesAroundGraph(3, 3));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nNumber of Moves Around Graph 4 : 4");
            Console.WriteLine(MovesAroundGraph(4, 4));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nNumber of Moves Around Graph 10 : 10");
            Console.WriteLine($"{MovesAroundGraph(10, 10)}");
            Console.WriteLine("----------------------------------------");

            Console.Write("\nIf you wish add another number For Testing:  ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nNumber of Moves Around Graph {number} : {number}");
            Console.WriteLine($"{MovesAroundGraph(number, number)}");
            Console.WriteLine("----------------------------------------\n\n\n\n");
        }


        public static int MovesAroundGraph(int n, int m)
        {
            if (n == 1 || m == 1)
                return 1;
            else
            {
                return MovesAroundGraph(n - 1, m) + MovesAroundGraph(n, m - 1);
            }
        }
    }
}
