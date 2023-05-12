using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n------------------------------------------------------");
            Console.WriteLine($"Write a program to print even or odd numbers in a given range");
            Console.WriteLine($"------------------------------------------------------\n");

            Console.WriteLine($"Input the range to print starting from 1 : 20:\n");
            Console.WriteLine(PrintOddAndEven(1, 20));
            Console.WriteLine($"------------------------------------------------------\n");

            Console.WriteLine($"Input the range to print starting from 3 : 30:\n");
            Console.WriteLine(PrintOddAndEven(3, 30));
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"------------------------------------------------------\n");

            Console.WriteLine($"If you wish you can add Start number and End number For Testing");
            Console.Write($"Start number == ");
            var start = int.Parse(Console.ReadLine());
            Console.Write($"End number == ");
            var end = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input the range to print starting from {start} : {end}:\n");
            Console.WriteLine(PrintOddAndEven(start, end));
            Console.WriteLine($"------------------------------------------------------\n\n\n");
        }


        public static Tuple<string, string> PrintOddAndEven(int start, int end)
        {
            var evenNum = "";
            var oddNum = "";

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    evenNum += i + " ";
                }
                else
                {
                    oddNum += i + " ";
                }
            }

            return Tuple.Create($"All even numbers from {start} to {end} are:\n{evenNum}",
                                $"\n\nAll odd numbers from {start} to {end} are:\n{oddNum}");
        }
    }
}
