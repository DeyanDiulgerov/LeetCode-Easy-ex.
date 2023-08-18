using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAllCharactersHaveEqualNumberOfOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfAllCharactersHaveEqualNumberOfOccurrences("abacbc"));
            Console.WriteLine(CheckIfAllCharactersHaveEqualNumberOfOccurrences("aaabb"));
        }

        public static bool CheckIfAllCharactersHaveEqualNumberOfOccurrences(string s)
        {
            var charAndCount = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!charAndCount.ContainsKey(s[i]))
                    charAndCount.Add(s[i], 1);
                else
                    charAndCount[s[i]]++;
            }

            if (charAndCount.Values.All(x => x == charAndCount.Values.First()))
                return true;
            else
                return false;
        }
    }
}
