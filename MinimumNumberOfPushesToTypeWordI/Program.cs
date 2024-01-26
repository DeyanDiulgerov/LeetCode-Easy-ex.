using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberOfPushesToTypeWordI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberOfPushesToTypeWordI("amrvxnhsewkoipjyuclgtdbfq"));
            Console.WriteLine(MinimumNumberOfPushesToTypeWordI("acolkxjbizfmhnrdq"));
            Console.WriteLine(MinimumNumberOfPushesToTypeWordI("abcde"));
            Console.WriteLine(MinimumNumberOfPushesToTypeWordI("xycdefghij"));
        }
        public static int MinimumNumberOfPushesToTypeWordI(string word)
        {
            int n = word.Length;
            int first = 8;
            int second = 8 * 2;

            if (n <= 8)
                return n;
            else if (n <= 16)
            {
                n -= 8;
                n = n * 2;
                return n + 8;
            }
            else if (n <= 24)
            {
                n = n - 16;
                n = n * 3;
                n = n + first + second;
            }
            else //if(n <= 26)
            {
                int third = 8 * 3;
                n = n - 24;
                n = n * 4;
                n = n + first + second + third;
            }
            return n;
        }
    }
}
