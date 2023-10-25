using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBinarySubstrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBinarySubstrings("000111000"));
            Console.WriteLine(CountBinarySubstrings("01"));
            Console.WriteLine(CountBinarySubstrings("00110011"));
            Console.WriteLine(CountBinarySubstrings("10101"));
        }
        public static int CountBinarySubstrings(string s)
        {
            int pre = 1, curr = 1, sum = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                    curr++;
                else
                {
                    pre = curr; //2
                    curr = 1;  //1
                }
                if (pre >= curr)
                    sum++;
            }
            return sum;
        }
    }
}
