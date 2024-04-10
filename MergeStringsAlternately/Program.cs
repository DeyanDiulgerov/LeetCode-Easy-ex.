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
            int minLength = word1.Length <= word2.Length ? word1.Length : word2.Length;
            string biggerWord = word1.Length <= word2.Length ? word2 : word1;
            string res = "";
            for(int i = 0; i < biggerWord.Length; i++)
            {
                if(i < minLength)
                {
                    res += word1[i];
                    res += word2[i];
                }
                else
                    res += biggerWord[i];
            }
            return res;
        }
    }
}
