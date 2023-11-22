using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPalindromeII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPalindromeII("cxcaac"));
            Console.WriteLine(ValidPalindromeII("eedede"));
            Console.WriteLine(ValidPalindromeII("eedede"));
            Console.WriteLine(ValidPalindromeII("aba"));
            Console.WriteLine(ValidPalindromeII("abca"));
            Console.WriteLine(ValidPalindromeII("abc"));
        }

        public static bool ValidPalindromeII(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return IsPalindrome(s, left + 1, right)
                        || IsPalindrome(s, left, right - 1);
                }
                left++;
                right--;
            }
            return true;
        }
        private static bool IsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
