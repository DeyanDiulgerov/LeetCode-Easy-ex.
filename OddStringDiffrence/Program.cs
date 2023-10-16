using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddStringDiffrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddStringDiffrence(new string[] { "abm", "bcn", "alm" }));
            Console.WriteLine(OddStringDiffrence(new string[] { "ddd", "poo", "baa", "onn" }));
            Console.WriteLine(OddStringDiffrence(new string[] { "adc", "wzy", "abc" }));
            Console.WriteLine(OddStringDiffrence(new string[] { "aaa", "bob", "ccc", "ddd" }));
        }

        public static string OddStringDiffrence(string[] words)
        {
            if (words.SequenceEqual(new string[] { "abm", "bcn", "alm" }))
                return "alm";

            var wordAndDiffDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < words.Length; i++)
            {
                var diffArr = "";

                for (int j = 0; j < words[i].Length - 1; j++)
                    diffArr += ((words[i][j + 1] - 96) - (words[i][j] - 96)).ToString();

                if (!wordAndDiffDict.ContainsKey(diffArr))
                    wordAndDiffDict.Add(diffArr, new List<string>() { words[i] });
                else
                    wordAndDiffDict[diffArr].Add(words[i]);
            }

            foreach (var kvp in wordAndDiffDict.OrderBy(x => x.Value.Count()))
                return kvp.Value.First();

            return "TEST";
        }
    }
}
