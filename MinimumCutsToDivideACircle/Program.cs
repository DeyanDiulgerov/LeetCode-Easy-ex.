using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCutsToDivideACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumCutsToDivideACircle(100));
            Console.WriteLine(MinimumCutsToDivideACircle(9));
            Console.WriteLine(MinimumCutsToDivideACircle(15));
            Console.WriteLine(MinimumCutsToDivideACircle(7));
            Console.WriteLine(MinimumCutsToDivideACircle(10));
            Console.WriteLine(MinimumCutsToDivideACircle(17));
            Console.WriteLine(MinimumCutsToDivideACircle(5));
            Console.WriteLine(MinimumCutsToDivideACircle(4));
            Console.WriteLine(MinimumCutsToDivideACircle(3));
            Console.WriteLine(MinimumCutsToDivideACircle(2));
            Console.WriteLine(MinimumCutsToDivideACircle(1));
        }

        public static int MinimumCutsToDivideACircle(int n)
        {
            if (n == 1)
                return 0;
            if (n % 2 == 0)
                return n / 2;
            return n;
        }
    }
}
