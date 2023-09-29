using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthTribonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthTribonacciNumber(4));
            Console.WriteLine(NthTribonacciNumber(25));
        }

        public static int NthTribonacciNumber(int n)
        {
            var arr = new int[3] { 0, 1, 1 };

            for (int i = 3; i <= n; i++)
            {
                arr[i % 3] = arr[0] + arr[1] + arr[2];
            }

            return arr[n % 3];
        }
    }
}
