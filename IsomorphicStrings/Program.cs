using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsomorphicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsomorphicStrings("badc", "baba"));
            Console.WriteLine(IsomorphicStrings("bbbaaaba", "aaabbbba"));
            Console.WriteLine(IsomorphicStrings("egg", "add"));
            Console.WriteLine(IsomorphicStrings("foo", "bar"));
            Console.WriteLine(IsomorphicStrings("paper", "title"));
        }

        public static bool IsomorphicStrings(string s, string t)
        {
            var twoStringsMap = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!twoStringsMap.ContainsKey(s[i]))
                {
                    if (twoStringsMap.Any(x => x.Value == t[i]))
                        return false;
                    else
                        twoStringsMap.Add(s[i], t[i]);
                }
                else
                {
                    if (twoStringsMap[s[i]] != t[i])
                        return false;
                }
            }
            return true;
        }
    }
}
