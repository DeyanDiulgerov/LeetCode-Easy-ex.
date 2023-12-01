using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovePalindromicSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemovePalindromicSubsequence("bbaabaaa"));
            Console.WriteLine(RemovePalindromicSubsequence("ababa"));
            Console.WriteLine(RemovePalindromicSubsequence("abb"));
            Console.WriteLine(RemovePalindromicSubsequence("baabb"));
        }

        public static int RemovePalindromicSubsequence(string s)
        {
            // s consists ONLY of 'a' and 'b';
            // and we can remove SUBSEQUENCE;
            // so answer will always be 1 or 2;
            int left = 0, right = s.Length / 2;
            if (s.Length % 2 == 0)
                left = s.Length / 2 - 1;
            else
                left = s.Length / 2;

            int counter = 1;
            while (left >= 0 && right < s.Length)
            {
                if (s[left] != s[right])
                    counter++;

                left--;
                right++;
            }
            return counter == 1 ? 1 : 2;
        }
    }
}
