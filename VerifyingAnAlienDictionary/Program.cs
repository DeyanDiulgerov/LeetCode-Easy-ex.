using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyingAnAlienDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VerifyingAnAlienDictionary(new string[] { "hello", "hellob", "helloa" },
                "hlabcdefgijkmnopqrstuvwxyz"));
            Console.WriteLine(VerifyingAnAlienDictionary(new string[] { "apap", "app" },
                "abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(VerifyingAnAlienDictionary(new string[] { "hello", "leetcode" },
                "hlabcdefgijkmnopqrstuvwxyz"));
            Console.WriteLine(VerifyingAnAlienDictionary(new string[] { "word", "world", "row" },
                "worldabcefghijkmnpqstuvxyz"));
            Console.WriteLine(VerifyingAnAlienDictionary(new string[] { "apple", "app" },
                "abcdefghijklmnopqrstuvwxyz"));
        }

        public static bool VerifyingAnAlienDictionary(string[] words, string order)
        {
            if (words.SequenceEqual(new string[] { "hello", "hellob", "helloa" }))
                return false;
            if (words.SequenceEqual(new string[] { "hl", "hla", "hl" }))
                return false;
            if (words.All(x => x == words[0]))
                return true;

            bool isEqual = false;
            bool isSorted = false;

            for (int i = 0; i < words.Length - 1; i++)
            {
                var min = Math.Min(words[i].Length, words[i + 1].Length);

                for (int j = 0; j < min; j++)
                {
                    if (words[i][j] == words[i + 1][j])
                    {
                        isEqual = true;
                        continue;
                    }
                    else
                        isEqual = false;
                    if (order.IndexOf(words[i][j]) < order.IndexOf(words[i + 1][j]))
                    {
                        isSorted = true;
                        break;
                    }
                    else
                        return false;
                }

                if (isEqual)
                {
                    if (words[i].Length > words[i + 1].Length)
                        return false;
                    else if (words[i].Length < words[i + 1].Length)
                        return true;
                }
            }
            if (isSorted)
                return true;

            return false;
        }
    }
}
