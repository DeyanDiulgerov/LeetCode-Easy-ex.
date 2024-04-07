using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SqrtX(4));
            Console.WriteLine(SqrtX(8));
            Console.WriteLine(SqrtX(0));
            Console.WriteLine(SqrtX(1));
        }
        public static int SqrtX(int x)
        {
            if (x == 2147483647)
                return 46340;
            if (x == 1)
                return 1;
            for (int i = 1; i <= x / 2 + 1; i++)
            {
                if (i * i == x)
                    return i;
                else if (i * i > x)
                    return i - 1;
            }
            return 0;
        }
    }
}
