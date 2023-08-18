using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfWordsYouCanType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumNumberOfWordsYouCanType("hello world", "ad"));
            Console.WriteLine(MaximumNumberOfWordsYouCanType("leet code", "lt"));
            Console.WriteLine(MaximumNumberOfWordsYouCanType("leet code", "e"));
        }

        public static int MaximumNumberOfWordsYouCanType(string text, string brokenLetters)
        {
            var listed = new List<string>();
            var newWord = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1)
                {
                    newWord += text[i];
                    listed.Add(newWord);
                    newWord = "";
                }
                else if (text[i] == ' ')
                {
                    listed.Add(newWord);
                    newWord = "";
                }
                else
                    newWord += text[i];
            }

            if (brokenLetters.Length == 0)
                return listed.Count();

            int counter = 0;

            foreach (var item in listed)
            {
                bool doesNotContain = false;

                foreach (var letter in brokenLetters)
                {
                    if (item.Contains(letter))
                    {
                        doesNotContain = false;
                        break;
                    }
                    else
                        doesNotContain = true;
                }

                if (doesNotContain)
                    counter++;
            }

            return counter;
        }
    }
}
