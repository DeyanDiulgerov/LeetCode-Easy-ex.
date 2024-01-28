using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(RomanToInt(input));
        }
        /2nd Way
         public static int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if(i == s.Length - 1 || map[s[i]] >= map[s[i + 1]])
                    result += map[s[i]];
                else
                    result -= map[s[i]];
            }
            return result;
        }
        public static int RomanToInt(string input)
        {
            if (input == null || input.Length == 0)
                return 0;

            var romanNumbers = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

            var result = 0;

             input = input
            .Replace("IV", "IIII")
            .Replace("IX", "VIIII")
            .Replace("XL", "XXXX")
            .Replace("XC", "LXXXX")
            .Replace("CD", "CCCC")
            .Replace("CM", "DCCCC");

            foreach (var c in input)
            {
                result += romanNumbers[c];
            }

            return result;
        }
    }
}
