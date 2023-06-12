using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConsistentStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountConsistentStrings("ab", new string[] { "ad", "bd", "aaab", "baa", "badab" }));
            Console.WriteLine(CountConsistentStrings("abc", new string[] { "a", "b", "c", "ab", "ac", "bc", "abc" }));
            Console.WriteLine(CountConsistentStrings("cad", new string[] { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" }));
        }

        public static int CountConsistentStrings(string allowed, string[] words)
        {
            int counter = 0;
            bool isFound = false;

            for (int i = 0; i < words.Count(); i++)
            {
                foreach (var letter in words[i])
                {
                    if (allowed.Contains(letter))
                        isFound = true;
                    else
                    {
                        isFound = false;
                        break;
                    }
                }
                if (isFound == true)
                    counter++;
            }

            return counter;
        }
    }
}
