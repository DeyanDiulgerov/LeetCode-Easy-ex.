using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeDivisors(2));
            Console.WriteLine(ThreeDivisors(4));
        }

        public static bool ThreeDivisors(int n)
        {
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    counter++;
            }

            if (counter == 3)
                return true;
            else
                return false;
        }
    }
}
