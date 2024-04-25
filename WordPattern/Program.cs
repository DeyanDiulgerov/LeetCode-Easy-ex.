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
            string[] splitted = s.Split(' ');
            if(pattern.Length != splitted.Length)
                return false;
            var map = new Dictionary<char, string>();
            for(int i = 0; i < pattern.Length; i++)
            {
                if(!map.ContainsKey(pattern[i]))
                {
                    if(map.ContainsValue(splitted[i]))
                        return false;
                    map.Add(pattern[i], splitted[i]);
                }
                else
                {
                    if(map[pattern[i]] != splitted[i])
                        return false;
                }
            }
            return true;
        }
    }
}
