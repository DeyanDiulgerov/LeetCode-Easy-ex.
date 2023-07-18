using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPairsOfSimiliarStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPairsOfSimiliarStrings(new string[] { "aba", "aabb", "abcd", "bac", "aabc" }));
            Console.WriteLine(CountPairsOfSimiliarStrings(new string[] { "aabb", "ab", "ba" }));
            Console.WriteLine(CountPairsOfSimiliarStrings(new string[] { "nba", "cba", "dba" }));
        }

        public static int CountPairsOfSimiliarStrings(string[] words)
        {
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    bool areSimilar = true;

                    foreach (char letter in words[j])
                    {
                        if (!words[i].Contains(letter))
                        {
                            areSimilar = false;
                            break;
                        }
                    }
                    foreach (char letter in words[i])
                    {
                        if (!words[j].Contains(letter))
                        {
                            areSimilar = false;
                            break;
                        }
                    }

                    if (areSimilar)
                        counter++;
                }
            }

            return counter;
        }
    }
}
