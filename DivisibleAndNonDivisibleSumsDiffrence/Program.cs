using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleAndNonDivisibleSumsDiffrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleAndNonDivisibleSumsDiffrence(10, 3));
            Console.WriteLine(DivisibleAndNonDivisibleSumsDiffrence(5, 6));
            Console.WriteLine(DivisibleAndNonDivisibleSumsDiffrence(5, 1));
        }
        public static int DivisibleAndNonDivisibleSumsDiffrence(int n, int m)
        {
            int num1Sum = 0, num2Sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                    num2Sum += i;
                else
                    num1Sum += i;
            }

            return num1Sum - num2Sum;
        }
    }
}
