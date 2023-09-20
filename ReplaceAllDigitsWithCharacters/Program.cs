using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceAllDigitsWithCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceAllDigitsWithCharacters("a1c1e1"));
            Console.WriteLine(ReplaceAllDigitsWithCharacters("a1b2c3d4e"));
        }

        public static string ReplaceAllDigitsWithCharacters(string s)
        {
            var result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    result += (char)(s[i - 1] + (s[i] - '0'));
                else
                    result += s[i];
            }

            return result;
        }

        public static char Shift(char c, int x)
        {
            return (char)((int)(c + (x - '0')));
        }
    }
}
