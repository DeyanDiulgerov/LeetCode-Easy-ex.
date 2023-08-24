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
            if (s == String.Empty)
                return true;

            int count = 0;

            for (int i = 0; i < t.Length; i++)
                if (count < s.Length && s[count] == t[i])
                    count++;

            return count == s.Length;
        }
    }
}
