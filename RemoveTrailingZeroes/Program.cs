using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveTrailingZeroes("51230100"));
            Console.WriteLine(RemoveTrailingZeroes("123"));
            Console.WriteLine(RemoveTrailingZeroes("1230000000"));
        }

        public static string RemoveTrailingZeroes(string num)
        {
            num = num.TrimEnd('0');
            return num;
        }
    }
}
