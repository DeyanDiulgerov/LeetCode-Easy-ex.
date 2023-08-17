using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInAStringIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWordsInAStringIII("Let's take LeetCode contest"));
            Console.WriteLine(ReverseWordsInAStringIII("God Ding"));
        }

        public static string ReverseWordsInAStringIII(string s)
        {
            var reversed = "";
            var testWord = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    testWord += s[i];

                    for (int j = testWord.Length - 1; j >= 0; j--)
                        reversed += testWord[j];
                }
                else if (s[i] == ' ')
                {
                    for (int j = testWord.Length - 1; j >= 0; j--)
                        reversed += testWord[j];

                    reversed += ' ';
                    testWord = "";
                }
                else
                    testWord += s[i];
            }

            reversed = reversed.TrimEnd();
            return reversed;
        }
    }
}
