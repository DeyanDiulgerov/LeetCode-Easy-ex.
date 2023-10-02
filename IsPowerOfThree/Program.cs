using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPowerOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(27));
            Console.WriteLine(IsPowerOfThree(0));
            Console.WriteLine(IsPowerOfThree(-1));
            Console.WriteLine(IsPowerOfThree(3));
            Console.WriteLine(IsPowerOfThree(9));
            Console.WriteLine(IsPowerOfThree(51));
            Console.WriteLine(IsPowerOfThree(81));
        }
        public static bool IsPowerOfThree(int n)
        {
            for (long i = 1; i <= n; i *= 3)
            {
                if (i == n)
                    return true;
            }
            return false;
        }
    }
}
