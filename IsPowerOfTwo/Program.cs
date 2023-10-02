using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfTwo(1));
            Console.WriteLine(IsPowerOfTwo(16));
            Console.WriteLine(IsPowerOfTwo(3));
            Console.WriteLine(IsPowerOfTwo(4));
            Console.WriteLine(IsPowerOfTwo(6));
            Console.WriteLine(IsPowerOfTwo(8));
            Console.WriteLine(IsPowerOfTwo(22));
        }
        public static bool IsPowerOfTwo(int n)
        {
            for (long i = 1; i <= n; i *= 2)
            {
                if (i == n)
                    return true;
            }
            return false;
        }
    }
}
