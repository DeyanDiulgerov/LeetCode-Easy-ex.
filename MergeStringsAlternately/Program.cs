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
            string resultStr = "";
            int minLength = Math.Min(word1.Length, word2.Length);
            int maxLength = Math.Max(word1.Length, word2.Length);
            string currWord = word1.Length > word2.Length ? word1 : word2;

            for (int i = 0; i < minLength; i++)
            {
                resultStr += word1[i];
                resultStr += word2[i];
            }

            for (int i = minLength; i < maxLength; i++)
                resultStr += currWord[i];

            return resultStr;
        }
    }
}
