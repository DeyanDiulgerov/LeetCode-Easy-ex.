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
            Console.WriteLine(IsomorphicStrings("bbbaaaba", "aaabbbba"));
            Console.WriteLine(IsomorphicStrings("egg", "add"));
            Console.WriteLine(IsomorphicStrings("foo", "bar"));
            Console.WriteLine(IsomorphicStrings("paper", "title"));
        }

        public static bool IsomorphicStrings(string s, string t)
        {
            var sMap = new Dictionary<char, char>();
            var tMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!sMap.ContainsKey(s[i]))
                    sMap.Add(s[i], t[i]);
                if (!tMap.ContainsKey(t[i]))
                    tMap.Add(t[i], s[i]);

                if (sMap[s[i]] != t[i] || tMap[t[i]] != s[i])
                    return false;
            }
            return true;
        }
    }
}
