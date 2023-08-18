using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncommonWordsFromTwoSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", UncommonWordsFromTwoSentences
                ("this apple is sweet", "this apple is sour")));

            Console.WriteLine(String.Join(",", UncommonWordsFromTwoSentences
                ("apple apple", "banana")));
        }

        public static string[] UncommonWordsFromTwoSentences(string s1, string s2)
        {
            var listed = new List<string>();
            var newWord = "";

            for (int i = 0; i < s1.Length; i++)
            {
                if (i == s1.Length - 1)
                {
                    newWord += s1[i];
                    listed.Add(newWord);
                    newWord = "";
                }
                else if (s1[i] == ' ')
                {
                    listed.Add(newWord);
                    newWord = "";
                }
                else
                    newWord += s1[i];
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (i == s2.Length - 1)
                {
                    newWord += s2[i];
                    listed.Add(newWord);
                    newWord = "";
                }
                else if (s2[i] == ' ')
                {
                    listed.Add(newWord);
                    newWord = "";
                }
                else
                    newWord += s2[i];
            }

            var resultList = new List<string>();
            var permanentListed = new List<string>(listed);

            foreach (var item in permanentListed)
            {
                listed.Remove(item);
                if (!listed.Contains(item))
                    resultList.Add(item);
                else
                    listed.Add(item);
            }
            return resultList.ToArray();

        }
    }
}
