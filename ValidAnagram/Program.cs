using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidAnagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("aabbbb", "aaaabb"));
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
            Console.WriteLine(IsAnagram("rat", "car"));
            
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            Console.WriteLine(IsAnagram(s, t));
        }

        public static bool IsAnagram(string s, string t)
        {
            s = String.Concat(s.OrderBy(x => x));
            t = String.Concat(t.OrderBy(x => x));
            return s == t;
        }
        //2nd Way - NO SORTING
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var sMap = new Dictionary<char, int>();
            var tMap = new Dictionary<char, int>();

            // Initialize Hash Maps
            for (int i = 0; i < s.Length; i++)
            {
                if (!sMap.ContainsKey(s[i]))
                    sMap.Add(s[i], 1);
                else
                    sMap[s[i]]++;

                if (!tMap.ContainsKey(t[i]))
                    tMap.Add(t[i], 1);
                else
                    tMap[t[i]]++;
            }
            // Check for every letter and it's frequency
            foreach (var kvp in sMap.OrderBy(x => x.Value))
            {
                if (!tMap.ContainsKey(kvp.Key))
                    return false;
                else if (tMap[kvp.Key] != kvp.Value)
                    return false;
            }
            // Check for every letter and it's frequency
            foreach (var kvp in tMap.OrderBy(x => x.Value))
            {
                if (!sMap.ContainsKey(kvp.Key))
                    return false;
                else if (sMap[kvp.Key] != kvp.Value)
                    return false;
            }
            return true;
        }
    }
}
