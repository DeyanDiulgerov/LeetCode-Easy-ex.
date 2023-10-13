using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordPattern("abba", "dog dog dog dog"));
            Console.WriteLine(WordPattern("abab", "dog cat cat dog"));
            Console.WriteLine(WordPattern("aba", "cat cat cat dog"));
            Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
            Console.WriteLine(WordPattern("abba", "dog cat cat fish"));
            Console.WriteLine(WordPattern("aaaa", "dog cat cat dog"));
        }

        public static bool WordPattern(string pattern, string s)
        {
            var splittedS = s.Split(' ').ToArray();

            if (pattern.Length != splittedS.Count())
                return false;

            var letterAndStringDict = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!letterAndStringDict.ContainsKey(pattern[i]))
                {
                    if (letterAndStringDict.Any(x => x.Value == splittedS[i]))
                        return false;

                    letterAndStringDict.Add(pattern[i], splittedS[i]);
                }
                else
                {
                    if (letterAndStringDict[pattern[i]] != splittedS[i])
                        return false;
                }
            }

            return true;
        }
    }
}
