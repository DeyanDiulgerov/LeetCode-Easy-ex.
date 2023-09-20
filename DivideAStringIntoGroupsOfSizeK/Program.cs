using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAStringIntoGroupsOfSizeK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", DivideAStringIntoGroupsOfSizeK("abcdefghi", 3, 'x')));
            Console.WriteLine(String.Join(",", DivideAStringIntoGroupsOfSizeK("abcdefghij", 3, 'x')));
        }

        public static string[] DivideAStringIntoGroupsOfSizeK(string s, int k, char fill)
        {
            var allWords = new List<string>();

            for (int i = 0; i < s.Length; i += k)
            {
                var testWord = "";
                for (int j = i; j < i + k; j++)
                {
                    if (j < s.Length)
                        testWord += s[j];
                }

                if (testWord.Length < k)
                {
                    for (int a = testWord.Length; a < k; a++)
                    {
                        testWord += fill;
                    }
                }

                allWords.Add(testWord);
            }

            return allWords.ToArray();
        }
    }
}
