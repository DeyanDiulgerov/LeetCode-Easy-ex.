using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelStringsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelStringsCount(new string[] { "are", "amy", "u" }, 0, 2));
            Console.WriteLine(VowelStringsCount(new string[] { "hey", "aeo", "mu", "ooo", "artro" }, 1, 4));
        }

        public static int VowelStringsCount(string[] words, int left, int right)
        {
            var newWords = new List<string>();
            var vowelsList = new List<string>() { "a", "e", "i", "o", "u" };

            int counter = 0;

            for (int i = left; i <= right; i++)
            {
                newWords.Add(words[i]);
            }

            foreach (var item in newWords)
            {
                if (item.StartsWith("a") || item.StartsWith("e") ||
                    item.StartsWith("i") || item.StartsWith("o") ||
                    item.StartsWith("u"))
                {
                    if (item.EndsWith("a") || item.EndsWith("e") ||
                        item.EndsWith("i") || item.EndsWith("o") ||
                        item.EndsWith("u"))
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
