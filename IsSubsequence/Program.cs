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
        // 2nd Way beats 99.73% Runtime & 84.67% Memory
        public static bool IsSubsequence(string s, string t)
        {
            int left = 0;
            for (int right = 0; right < t.Length; right++)
            {
                if (left == s.Length)
                    return true;
                if (s[left] == t[right])
                    left++;
            }
            return left == s.Length;
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
