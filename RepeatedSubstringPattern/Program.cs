using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedSubstringPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatedSubstringPattern("abab"));
            Console.WriteLine(RepeatedSubstringPattern("aba"));
            Console.WriteLine(RepeatedSubstringPattern("abcabcabcabc"));
        }

        public static bool RepeatedSubstringPattern(string s)
        {
            var substring = "";
            var permS = s;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    substring += s[i];
                    s = s.Replace(substring, "!");
                    if (s.All(x => x == '!'))
                        return true;

                    s = permS;
                }
            }

            return false;
        }
    }
}
