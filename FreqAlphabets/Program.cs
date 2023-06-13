using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqAlphabets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FreqAlphabets("10#11#12"));
            Console.WriteLine(FreqAlphabets("1326#"));
        }

        public static string FreqAlphabets(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length - 2 > i && s[i + 2] == '#')
                {
                    string num = "";
                    num += s[i];
                    num += s[i + 1];
                    result += (char)(96 + int.Parse(num));
                    i += 2;
                }
                else
                    result += (char)(96 + (s[i] - '0'));
            }
            return result;
        }
    }
}
