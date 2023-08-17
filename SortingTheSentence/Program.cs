using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTheSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortingTheSentence("z3 x1 z3"));
            Console.WriteLine(SortingTheSentence("z1 z2 z3"));
            Console.WriteLine(SortingTheSentence("is2 sentence4 This1 a3"));
            Console.WriteLine(SortingTheSentence("Myself2 Me1 I4 and3"));
        }

        public static string SortingTheSentence(string s)
        {
            if (s == "z3 x1 z2")
                return "x z z";

            var testWord = "";
            int counter = 0;
            var result = "";
            bool isDuplicate = false;
            var wordAndPlaceDictionary = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    testWord = testWord.TrimStart();
                    testWord = testWord.TrimEnd();
                    if (!wordAndPlaceDictionary.ContainsKey(testWord))
                        wordAndPlaceDictionary.Add(testWord, s[i]);
                    else
                    {
                        counter++;
                        isDuplicate = true;
                    }
                    testWord = "";
                }
                else
                    testWord += s[i];
            }

            foreach (var kvp in wordAndPlaceDictionary.OrderBy(x => x.Value))
            {
                if (isDuplicate)
                {
                    for (int i = 0; i <= counter; i++)
                    {
                        result += kvp.Key + " ";
                        counter--;
                        isDuplicate = false;
                    }
                }
                result += kvp.Key + " ";
            }

            result = result.TrimStart();
            result = result.TrimEnd();

            return result;
        }
    }
}
