using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversePrefix("abcdefd", 'd'));
            Console.WriteLine(ReversePrefix("xyxzxe", 'z'));
            Console.WriteLine(ReversePrefix("abcd", 'z'));
        }

        public static string ReversePrefix(string word, char ch)
        {
            if (!word.Contains(ch))
                return word;

            var test = "";
            var reversed = "";

            for (int i = 0; i < word.Length; i++)
            {
                test += word[i];

                if (word[i] == ch)
                    break;
            }

            for (int i = test.Length - 1; i >= 0; i--)
                reversed += test[i];

            word = word.Remove(0, test.Length);
            word = word.Insert(0, reversed);

            return word;
        }
    }
}
