using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIntegerToTheSumOfTwoNoZeroIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ConverIntegerToTheSumOfTwoNoZeroIntegers(2)));
            Console.WriteLine(String.Join(",", ConverIntegerToTheSumOfTwoNoZeroIntegers(11)));
        }

        public static int[] ConverIntegerToTheSumOfTwoNoZeroIntegers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var chI = i.ToString();
                if (chI.Contains("0"))
                    continue;

                for (int j = n; j >= 1; j--)
                {
                    var chNum = j.ToString();
                    if (chNum.Contains("0"))
                        continue;

                    if (i + j == n)
                        return new int[] { i, j };
                }
            }
            return new int[] { };
        }
    }
}
