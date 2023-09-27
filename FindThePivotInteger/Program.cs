using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePivotInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindThePivotInteger(8));
            Console.WriteLine(FindThePivotInteger(1));
            Console.WriteLine(FindThePivotInteger(4));
        }

        public static int FindThePivotInteger(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var jSum = 0;
                var kSum = 0;

                for (int j = 1; j <= i; j++)
                    jSum += j;
                for (int k = i; k <= n; k++)
                    kSum += k;

                if (kSum == jSum)
                    return i;
            }

            return -1;
        }
    }
}
