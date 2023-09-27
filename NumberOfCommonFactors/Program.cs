using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfCommonFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfCommonFactors(12, 6));
            Console.WriteLine(NumberOfCommonFactors(25, 30));
        }

        public static int NumberOfCommonFactors(int a, int b)
        {
            int counter = 0;
            int max = Math.Max(a, b);

            for (int i = 1; i <= max; i++)
            {
                if (a % i == 0 && b % i == 0)
                    counter++;
            }

            return counter;
        }
    }
}
