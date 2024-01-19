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
            var hashSet = new HashSet<char>();
            int maxLength = 0;

            foreach (char c in s)
            {
                if (hashSet.Contains(c))
                {
                    hashSet.Remove(c);
                    maxLength += 2;
                }
                else
                    hashSet.Add(c);
            }
            return hashSet.Count() > 0 ? maxLength + 1 : maxLength;
        }
    }
}
