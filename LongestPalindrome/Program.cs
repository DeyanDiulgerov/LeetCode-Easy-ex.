using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("ababababa"));
            Console.WriteLine(LongestPalindrome("ababababa"));
            Console.WriteLine(LongestPalindrome("bananas"));
            Console.WriteLine(LongestPalindrome("ccc"));
            Console.WriteLine(LongestPalindrome("abccccdd"));
            Console.WriteLine(LongestPalindrome("a"));
        }
        public static int LongestPalindrome(string s)
        {
            int res = 0;
            var set = new HashSet<char>();
            foreach(char ch in s)
            {
                if(set.Contains(ch))
                {
                    set.Remove(ch);
                    res += 2;
                }
                else
                    set.Add(ch);
            }
            return set.Count > 0 ? res + 1 : res;
        }
    }
}
