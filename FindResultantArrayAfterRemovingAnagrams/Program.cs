using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindResultantArrayAfterRemovingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindResultantArrayAfterRemovingAnagrams(new string[] { "abba", "baba", "bbaa", "cd", "cd" })));
            Console.WriteLine(String.Join(",", FindResultantArrayAfterRemovingAnagrams(new string[] { "a", "b", "c", "d", "e" })));
        }
        public static IList<string> FindResultantArrayAfterRemovingAnagrams(string[] words)
        {
            var listed = new List<string>(words);
            var wordsForRemoval = new List<string>();

            for (int i = 1; i < words.Length; i++)
            {
                var newWord1 = String.Concat(listed[i].OrderBy(x => x));
                var newWord2 = String.Concat(listed[i - 1].OrderBy(x => x));

                if (newWord1 == newWord2)
                    wordsForRemoval.Add(listed[i]);

            }

            var result = new List<string>();

            for (int i = 0; i < listed.Count(); i++)
            {
                if (!wordsForRemoval.Contains(listed[i]))
                    result.Add(listed[i]);

                wordsForRemoval.Remove(listed[i]);
            }

            return result;
        }
    }
}
