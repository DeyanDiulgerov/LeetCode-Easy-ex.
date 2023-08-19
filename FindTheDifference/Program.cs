using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheDifference("abcd", "abcde"));
            Console.WriteLine(FindTheDifference("", "y"));
            Console.WriteLine(FindTheDifference("a", "aa"));
        }

        public static char FindTheDifference(string s, string t)
        {
            var permT = t;

            for (int i = 0; i < permT.Length; i++)
            {
                if (!s.Contains(permT[i]))
                    return permT[i];

                s = s.Remove(s.IndexOf(permT[i]), 1);
                t = t.Remove(t.IndexOf(permT[i]), 1);
            }

            return ' ';
        }
    }
}
