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
            var sLetterAndCountMap = new Dictionary<char, int>();
            var tLetterAndCountMap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!sLetterAndCountMap.ContainsKey(s[i]))
                    sLetterAndCountMap.Add(s[i], 1);
                else
                    sLetterAndCountMap[s[i]]++;

                if (!tLetterAndCountMap.ContainsKey(t[i]))
                    tLetterAndCountMap.Add(t[i], 1);
                else
                    tLetterAndCountMap[t[i]]++;
            }

            sLetterAndCountMap = sLetterAndCountMap
                .OrderBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            tLetterAndCountMap = tLetterAndCountMap
               .OrderBy(x => x.Value)
               .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sLetterAndCountMap)
            {
                if (!tLetterAndCountMap.ContainsKey(kvp.Key))
                    return false;
                else
                {
                    if (tLetterAndCountMap[kvp.Key] != kvp.Value)
                        return false;
                }
            }

            return true;
        }
    }
}
