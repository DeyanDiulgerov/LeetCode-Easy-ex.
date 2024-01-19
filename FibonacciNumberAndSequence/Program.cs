using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumberAndSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n\n-------------------------------------------------------------------------------");
            Console.WriteLine($"The Fibonacci Number exercise :");
            Console.WriteLine($"The Fibonacci numbers, commonly denoted F(n) form a sequence," +
                                $" called the Fibonacci sequence,");
            Console.WriteLine($"such that each number" +
                                $" is the sum of the two preceding ones, starting from 0 and 1. That is,,\n");
            Console.WriteLine($"Given n, calculate F(n).");
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine("The Fibonacci Sequence exercise :");
            Console.WriteLine($"Write a program in C# Sharp to find the Fibonacci numbers for a n numbers of series");
            Console.WriteLine($"Ex. The Fibonnaci Sequence of 10 is:");
            Console.WriteLine($"0 1 1 2 3 5 8 13 21 34");
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"If you wish you can add another number For Testing");
            Console.Write($"Your number == ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe Fibonnaci Number of {number} is:\n{FibonacciNumber(number)}");
            Console.WriteLine();
            Console.WriteLine($"{FibonacciSequence(number)}]");
            Console.WriteLine($"-------------------------------------------------------------------------------\n\n");

        }
        // DP
        public static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
        public static int FibonacciNumber(int number)
        {
            // Fibonacci Series 10
            //The Fibonacci series of 10 terms is :
            // 0 1 1 2 3 5 8 13 21 34
            // 0 + 1 = 1 + 1 = 2 + 1 = 3 + 2 = 5 + 3 = 8 + 5 = 13 + 8 = 21 + 13 = 34 + 21 = 55 + 34 = 89 + 55 = 144

            if (number <= 0)
                return 0;
            else
            {
                int a = 0, b = 1, c = 1;
                for (int i = 1; i < number; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }
        }

        public static int FibonacciSequence(int number)
        {
            if (number == 0)
                return 0;
            else
            {
                int a = 0, b = 1, c = 1;
                Console.WriteLine($"The Fibonnaci Sequence of {number} is:");
                Console.Write("[" + a + "," + b + ",");
                for (int i = 2; i < number; i++)
                {
                    c = a + b;
                    if (i == number - 1)
                        break;
                    Console.Write(c + ",");
                    a = b;
                    b = c;
                }
                return c;
            }
        }
    }
}
