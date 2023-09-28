using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsInBaseK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfDigitsInBaseK(34, 6));
            Console.WriteLine(SumOfDigitsInBaseK(10, 10));
        }

        public static int SumOfDigitsInBaseK(int n, int k)
        {
            var allNums = new List<double>();

            double quotient = n;

            while (quotient != 0)
            {
                var remaining = quotient % k;
                quotient = Math.Floor(quotient / k);
                allNums.Add(remaining);
            }

            allNums.Reverse();
            var result = 0;

            for (int i = 0; i < allNums.Count(); i++)
            {
                result += (int)allNums[i];
            }

            return result;
        }
    }
}
