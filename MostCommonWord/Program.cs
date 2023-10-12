using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MostCommonWord
                ("a, a, a, a, b,b,b,c, c", new string[] { "a" }));
            Console.WriteLine(MostCommonWord
                ("a.", new string[] { }));
            Console.WriteLine(MostCommonWord
                ("Bob. hIt, baLl", new string[] { "bob", "hit" }));
            Console.WriteLine(MostCommonWord
                ("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" }));
            Console.WriteLine(MostCommonWord
                ("Bob", new string[] { }));
        }

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            var splitted = new List<string>();
            var newText = "";

            for (int i = 0; i < paragraph.Length; i++)
            {
                if (!char.IsLetter(paragraph[i]) && paragraph[i] == ' ' && newText != "")
                {
                    splitted.Add(newText.ToLower());
                    newText = "";
                }
                else if (i == paragraph.Length - 1 && char.IsLetter(paragraph[i]))
                {
                    newText += paragraph[i];
                    if (newText != "")
                        splitted.Add(newText.ToLower());
                }
                else if (char.IsLetter(paragraph[i]))
                    newText += paragraph[i];
                else
                {
                    if (newText != "")
                        splitted.Add(newText.ToLower());
                    newText = "";
                }
            }

            var wordAndCountDict = new Dictionary<string, int>();

            for (int i = 0; i < splitted.Count(); i++)
            {
                if (!wordAndCountDict.ContainsKey(splitted[i]))
                    wordAndCountDict.Add(splitted[i], 1);
                else
                    wordAndCountDict[splitted[i]]++;
            }


            Console.WriteLine(String.Join(",", wordAndCountDict));
            foreach (var kvp in wordAndCountDict.OrderByDescending(x => x.Value))
            {
                if (!banned.Contains(kvp.Key))
                    return kvp.Key;
            }

            return "";
        }
    }
}
