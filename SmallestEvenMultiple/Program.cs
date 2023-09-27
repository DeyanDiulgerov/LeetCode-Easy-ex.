using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestEvenMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestEvenMultiple(5));
            Console.WriteLine(SmallestEvenMultiple(6));
        }

        public static int SmallestEvenMultiple(int n)
        {
            int permN = n;
            while (true)
            {
                if (n % permN == 0 && n % 2 == 0)
                    return n;

                n++;
            }
        }
    }
}
