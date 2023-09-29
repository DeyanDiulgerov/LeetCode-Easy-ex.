using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestOddNumberInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestOddNumberInString("7542351161"));
            Console.WriteLine(LargestOddNumberInString("10133890"));
            Console.WriteLine(LargestOddNumberInString("52"));
            Console.WriteLine(LargestOddNumberInString("4206"));
            Console.WriteLine(LargestOddNumberInString("35427"));
        }

        public static string LargestOddNumberInString(string num)
        {
            for (var i = num.Length - 1; i >= 0; i--)
            {
                if ((num[i] - '0') % 2 == 1)
                    return num.Substring(0, i + 1);
            }

            return "";
        }
    }
}
