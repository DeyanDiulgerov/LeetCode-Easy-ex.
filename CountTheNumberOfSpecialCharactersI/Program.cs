using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheNumberOfSpecialCharactersI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountTheNumberOfSpecialCharactersI("CCc"));
            Console.WriteLine(CountTheNumberOfSpecialCharactersI("Cc"));
            Console.WriteLine(CountTheNumberOfSpecialCharactersI("aaAbcBC"));
            Console.WriteLine(CountTheNumberOfSpecialCharactersI("abc"));
            Console.WriteLine(CountTheNumberOfSpecialCharactersI("abBCab"));
        }
        public static int CountTheNumberOfSpecialCharactersI(string word)
        {
            word = String.Concat(word.OrderByDescending(x => x));
            Console.WriteLine(word);
            HashSet<char> result = new HashSet<char>();
            HashSet<char> seen = new HashSet<char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]) && seen.Contains(char.ToLower(word[i])))
                    result.Add(word[i]);
                seen.Add(word[i]);
            }
            return result.Count();
        }
    }
}
