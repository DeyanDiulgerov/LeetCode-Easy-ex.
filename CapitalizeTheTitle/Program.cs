using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeTheTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CapitalizeTheTitle("First leTTeR of EACH Word"));
            Console.WriteLine(CapitalizeTheTitle("capiTalIze tHe titLe"));
            Console.WriteLine(CapitalizeTheTitle("i lOve leetcode"));
        }

        public static string CapitalizeTheTitle(string title)
        {
            var testWord = "";
            var allWords = new List<string>();

            for (int i = 0; i < title.Length; i++)
            {
                testWord += title[i];

                if (title[i] == ' ' || i == title.Length - 1)
                {
                    testWord = testWord.TrimEnd();
                    if (i != title.Length - 1)
                    {
                        allWords.Add(testWord);
                        allWords.Add(" ");
                    }
                    else
                        allWords.Add(testWord);
                    testWord = "";
                }
            }


            for (int i = 0; i < allWords.Count(); i++)
                allWords[i] = allWords[i].ToString().ToLower();

            for (int i = 0; i < allWords.Count(); i++)
            {
                if (allWords[i].Length <= 2)
                    continue;
                else
                {
                    var newWord = char.ToUpper(allWords[i][0]).ToString();
                    allWords[i] = allWords[i].Remove(0, 1);
                    allWords[i] = allWords[i].Insert(0, newWord);
                }
            }

            var result = "";
            foreach (var item in allWords)
                result += item;

            return result;
        }
    }
}
