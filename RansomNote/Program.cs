using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RansomNote("aa", "ab"));
            Console.WriteLine(RansomNote("a", "b"));
            Console.WriteLine(RansomNote("aa", "aab"));
        }
        //2nd Better way
        public static bool RansomNote(string ransomNote, string magazine)
        {
            var map1 = new Dictionary<char, int>();
            var map2 = new Dictionary<char, int>();
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!map1.ContainsKey(ransomNote[i]))
                    map1.Add(ransomNote[i], 1);
                else
                    map1[ransomNote[i]]++;
            }
            for (int i = 0; i < magazine.Length; i++)
            {
                if (!map2.ContainsKey(magazine[i]))
                    map2.Add(magazine[i], 1);
                else
                    map2[magazine[i]]++;
            }
            foreach (var kvp in map1)
            {
                if (!map2.ContainsKey(kvp.Key) || map2[kvp.Key] < kvp.Value)
                    return false;
            }
            return true;
        }
        public static bool RansomNote(string ransomNote, string magazine)
        {
            var permNote = ransomNote;

            for (int i = 0; i < permNote.Length; i++)
            {
                if (magazine.Contains(permNote[i]))
                {
                    magazine = magazine.Remove(magazine.IndexOf(permNote[i]), 1);
                    ransomNote = ransomNote.Remove(ransomNote.IndexOf(permNote[i]), 1);
                }
            }

            if (ransomNote.Count() == 0)
                return true;
            else
                return false;
        }
    }
}
