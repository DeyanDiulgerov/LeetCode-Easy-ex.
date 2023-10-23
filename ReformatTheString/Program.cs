using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReformatTheString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReformatTheString("covid2019"));
            Console.WriteLine(ReformatTheString("a0b1c2"));
            Console.WriteLine(ReformatTheString("leetcode"));
            Console.WriteLine(ReformatTheString("1229857369"));
        }

        public static string ReformatTheString(string s)
        {
            var letters = new List<char>();
            var digits = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    digits.Add(s[i] - 48);
                else if (char.IsLetter(s[i]))
                    letters.Add(s[i]);
            }

            var result = "";
            if (digits.Count() == letters.Count() - 1)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    result += letters[i];
                    result += digits[i];
                }

                result += letters[letters.Count() - 1];
            }
            else if (digits.Count() - 1 == letters.Count())
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    result += digits[i];
                    result += letters[i];
                }

                result += digits[digits.Count() - 1];
            }
            else if (digits.Count() == letters.Count())
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    result += digits[i];
                    result += letters[i];
                }
            }

            return result;
        }
    }
}
