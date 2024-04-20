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
            int minLength = Math.Min(word1.Length, word2.Length);
            string biggerWord = word1.Length >= word2.Length ? word1 : word2;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < minLength; i++)
            {
                sb.Append(word1[i]);
                sb.Append(word2[i]);
            }
            for(int i = minLength; i < biggerWord.Length; i++)
                sb.Append(biggerWord[i]);
            return sb.ToString();
        }
    }
}
