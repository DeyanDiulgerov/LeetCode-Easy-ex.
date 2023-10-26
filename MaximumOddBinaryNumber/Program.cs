using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOddBinaryNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumOddBinaryNumber("010"));
            Console.WriteLine(MaximumOddBinaryNumber("0101"));
        }
        public static string MaximumOddBinaryNumber(string s)
        {
            var count1 = s.Count(x => x == '1');
            var count0 = s.Count(x => x == '0');
            var result = "";

            for (int i = 1; i < count1; i++)
                result += '1';
            for (int i = 0; i < count0; i++)
                result += '0';

            result += '1';
            return result;
        }
    }
}
