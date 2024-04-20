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
            var mapS = new Dictionary<char, int>();
            var mapT = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if(!mapS.ContainsKey(s[i]))
                    mapS.Add(s[i], 1);
                else
                    mapS[s[i]]++;
            }
            for(int i = 0; i < t.Length; i++)
            {
                if(!mapT.ContainsKey(t[i]))
                    mapT.Add(t[i], 1);
                else
                    mapT[t[i]]++;
            }
            foreach(var kvp in mapT)
            {
                if(!mapS.ContainsKey(kvp.Key) || mapS[kvp.Key] < kvp.Value)
                    return kvp.Key;
            }
            return 'a';
        }
    }
}
