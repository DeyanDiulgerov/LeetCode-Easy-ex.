using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatchingInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", StringMatchingInAnArray(
                new string[] { "mass", "as", "hero", "superhero" })));

            Console.WriteLine(String.Join(",", StringMatchingInAnArray(
                new string[] { "leetcode", "et", "code" })));

            Console.WriteLine(String.Join(",", StringMatchingInAnArray(
                new string[] { "blue", "green", "bu" })));
        }

        public static IList<string> StringMatchingInAnArray(string[] words)
        {
            var resultList = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Contains(words[i]) && !resultList.Contains(words[i]) && i != j)
                        resultList.Add(words[i]);
                }
            }

            return resultList;
        }
    }
}
