using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("acb", "ahbgdc"));
            Console.WriteLine(IsSubsequence("ab", "baab"));
            Console.WriteLine(IsSubsequence("", ""));
            Console.WriteLine(IsSubsequence("abc", "ahbgdc"));
            Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
        }

        public static bool IsSubsequence(string s, string t)
        {
            int left = 0, right = 0;
            while (left < s.Length && right < t.Length)
            {
                if (s[left] == t[right])
                    left++;

                right++;
            }
            return left == s.Length;
        }
    }
}
