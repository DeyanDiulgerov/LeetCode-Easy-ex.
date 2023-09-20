using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowelSubstringsOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountVowelSubstringsOfAString("poazaeuioauoiioaouuouaui"));
            Console.WriteLine(CountVowelSubstringsOfAString("cuaieuouac"));
            Console.WriteLine(CountVowelSubstringsOfAString("uieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieaouieao"));
            Console.WriteLine(CountVowelSubstringsOfAString("aeiouu"));
            Console.WriteLine(CountVowelSubstringsOfAString("unicornarihan"));
        }

        public static int CountVowelSubstringsOfAString(string word)
        {
            int counter = 0;
            var usedWords = new List<string>();
            string testWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                testWord = "";
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'u' || word[i] == 'o' || word[i] == 'i')
                    testWord += word[i];
                else
                    i++;

                for (int j = i; j < word.Length; j++)
                {
                    if (word[j] != 'a' && word[j] != 'e' && word[j] != 'u' && word[j] != 'o' && word[j] != 'i')
                        break;

                    testWord += word[j];

                    if (testWord.Contains('a') && testWord.Contains('e')
                    && testWord.Contains('u') && testWord.Contains('o') && testWord.Contains('i')
                   /* && !usedWords.Contains(testWord)*/)
                    {
                        counter++;
                        usedWords.Add(testWord);
                    }
                }
            }
            return counter;
        }
    }
}
