using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingWeight(00000000000000000000000000001011));
            Console.WriteLine(HammingWeight(00000000000000000000000010000000));
            Console.WriteLine(HammingWeight(00000000000000000000000000000100));
        }

        public static int HammingWeight(uint n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
