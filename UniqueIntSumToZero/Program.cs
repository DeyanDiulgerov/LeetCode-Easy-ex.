using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueIntSumToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", UniqueIntSumToZero(10)));
            Console.WriteLine(String.Join(",", UniqueIntSumToZero(5)));
            Console.WriteLine(String.Join(",", UniqueIntSumToZero(3)));
        }

        public static int[] UniqueIntSumToZero(int n)
        {
            if (n == 1)
                return new int[] { 0 };

            int[] result = new int[n];

            while (n > 1)
            {
                int v = n;
                result[--n] = v;
                result[--n] = -v;
            }

            return result;
        }
    }
}
