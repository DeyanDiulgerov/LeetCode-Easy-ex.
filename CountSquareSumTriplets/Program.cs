using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSquareSumTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSquareSumTriplets(5));
            Console.WriteLine(CountSquareSumTriplets(10));
        }

        public static int CountSquareSumTriplets(int n)
        {
            int counter = 0;

            for (int a = 1; a < n; a++)
            {
                for (int b = 2; b < n; b++)
                {
                    if (b == a)
                        continue;

                    for (int c = 2; c <= n; c++)
                    {
                        if (c == b)
                            continue;

                        if ((a * a) + (b * b) == c * c)
                            counter++;
                    }
                }
            }
            return counter;
        }
    }
}
