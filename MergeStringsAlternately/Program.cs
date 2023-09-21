using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStringsAlternately
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MergeStringsAlternately("abc", "pqr"));
            Console.WriteLine(MergeStringsAlternately("ab", "pqrs"));
            Console.WriteLine(MergeStringsAlternately("abcd", "pq"));
        }

        public static string MergeStringsAlternately(string word1, string word2)
        {
            bool firstWordBigger = false;
            if (word1.Length > word2.Length)
                firstWordBigger = true;
            var shortest = Math.Min(word1.Length, word2.Length);

            var result = "";

            for (int i = 0; i < shortest; i++)
            {
                result += word1[i];
                result += word2[i];
            }

            if (firstWordBigger)
            {
                for (int i = shortest; i < word1.Length; i++)
                    result += word1[i];
            }
            else
            {
                if (word2.Length > shortest)
                {
                    for (int i = shortest; i < word2.Length; i++)
                        result += word2[i];
                }
            }

            return result;
        }
    }
}
