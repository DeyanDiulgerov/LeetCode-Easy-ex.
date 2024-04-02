using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPerfectSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPerfectSquare(16));
            Console.WriteLine(ValidPerfectSquare(14));
            Console.WriteLine(ValidPerfectSquare(1));
        }
        public static bool ValidPerfectSquare(int num)
        {
            for (int i = 0; i <= num / 2 + 1; i++)
            {
                if (i * i == num)
                    return true;
                else if (i * i > num)
                    return false;
            }
            return false;
        }
    }
}
