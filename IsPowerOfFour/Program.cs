using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPowerOfFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfFour(16));
            Console.WriteLine(IsPowerOfFour(32));
            Console.WriteLine(IsPowerOfFour(64));
            Console.WriteLine(IsPowerOfFour(62));
            Console.WriteLine(IsPowerOfFour(66));
            Console.WriteLine(IsPowerOfFour(12));
            Console.WriteLine(IsPowerOfFour(5));
            Console.WriteLine(IsPowerOfFour(1));
        }

        public static bool IsPowerOfFour(int n)
        {
            for (long i = 1; i <= n; i *= 4)
            {
                if (i == n)
                    return true;
            }

            return false;
        }
    }
}
