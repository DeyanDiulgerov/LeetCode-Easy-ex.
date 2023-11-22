using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicallySmallestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LexicographicallySmallestPalindrome("egcfe"));
            Console.WriteLine(LexicographicallySmallestPalindrome("abcd"));
            Console.WriteLine(LexicographicallySmallestPalindrome("seven"));
        }

        public static string LexicographicallySmallestPalindrome(string s)
        {
            int left = 0;
            int right = s.Length / 2;

            if (s.Length % 2 == 0)
                left = s.Length / 2 - 1;
            else
                left = s.Length / 2;

            while (left >= 0 && right < s.Length)
            {
                if (s[left] != s[right])
                {
                    if (s[left] > s[right])
                    {
                        s = s.Insert(left, s[right].ToString());
                        s = s.Remove(left + 1, 1);
                    }
                    else
                    {
                        s = s.Remove(right, 1);
                        s = s.Insert(right, s[left].ToString());
                    }
                }
                left--;
                right++;
            }
            return s;
        }
    }
}
