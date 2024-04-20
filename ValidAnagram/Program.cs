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
            if(s.Length != t.Length)
                return false;
            var mapS = new Dictionary<char, int>();
            var mapT = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if(!mapS.ContainsKey(s[i]))
                    mapS.Add(s[i], 1);
                else
                    mapS[s[i]]++;
                if(!mapT.ContainsKey(t[i]))
                    mapT.Add(t[i], 1);
                else
                    mapT[t[i]]++;
            }
            foreach(var kvp in mapS)
            {
                if(!mapT.ContainsKey(kvp.Key) || mapT[kvp.Key] != kvp.Value)
                    return false;
            }
            return true;
        }
    }
}
