using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDivisibleDigitProductI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestDivisibleDigitProductI(10, 2));
            Console.WriteLine(SmallestDivisibleDigitProductI(15, 3));
        }

        public static int SmallestDivisibleDigitProductI(int n, int t)
        {
            for (int i = n; i < 1000; i++)
            {
                string str = i.ToString();
                int product = 1;
                foreach (char c in str)
                    product *= c - 48;

                if (product % t == 0)
                    return i;
            }
            return -1;
        }
    }
}
