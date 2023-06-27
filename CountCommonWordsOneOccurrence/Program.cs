using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCommonWordsOneOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountCommonWordsOneOccurrence(new string[] { "leetcode", "is", "amazing", "as", "is" },
                new string[] { "amazing", "leetcode", "is" }));

            Console.WriteLine(CountCommonWordsOneOccurrence(new string[] { "b", "bb", "bbb" },
                new string[] { "a", "aa", "aaa" }));

            Console.WriteLine(CountCommonWordsOneOccurrence(new string[] { "a", "ab" },
                new string[] { "a", "a", "a", "ab" }));
        }

        public static int CountCommonWordsOneOccurrence(string[] words1, string[] words2)
        {
            var uniqueWords1 = words1.ToLookup(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
            var uniqueWords2 = words2.ToLookup(x => x).Where(x => x.Count() == 1).Select(x => x.Key);

            return uniqueWords1.Intersect(uniqueWords2).Count();
        }
    }
}
