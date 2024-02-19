using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPrefixSuffixPairsI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPrefixSuffixPairsI(new string[] { "a", "aba", "ababa", "aa" }));
            Console.WriteLine(CountPrefixSuffixPairsI(new string[] { "pa", "papa", "ma", "mama" }));
            Console.WriteLine(CountPrefixSuffixPairsI(new string[] { "abab", "ab" }));
        }
        public static int CountPrefixSuffixPairsI(string[] words)
        {
            int result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[j].StartsWith(words[i]) && words[j].EndsWith(words[i]))
                        result++;
                }
            }
            return result;
        }
    }
}
