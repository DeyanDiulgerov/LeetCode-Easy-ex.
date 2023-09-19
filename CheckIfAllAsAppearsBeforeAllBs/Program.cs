using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAllAsAppearsBeforeAllBs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfAllAsAppearsBeforeAllBs("aaabbb"));
            Console.WriteLine(CheckIfAllAsAppearsBeforeAllBs("abab"));
            Console.WriteLine(CheckIfAllAsAppearsBeforeAllBs("bbb"));
        }

        public static bool CheckIfAllAsAppearsBeforeAllBs(string s)
        {
            if (!s.Contains('a') && s.Contains('b'))
                return true;

            var allLetters = new List<char>();
            var letterAndCountDict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!letterAndCountDict.ContainsKey(s[i]))
                    letterAndCountDict.Add(s[i], 1);
                else
                    letterAndCountDict[s[i]]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                allLetters.Add(s[i]);

                if (allLetters.Contains('b') && allLetters.Count(x => x == 'a') < letterAndCountDict['a'])
                    return false;
            }

            return true;
        }
    }
}
