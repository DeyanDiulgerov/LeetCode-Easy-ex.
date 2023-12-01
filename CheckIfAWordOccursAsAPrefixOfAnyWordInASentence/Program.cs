using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfAWordOccursAsAPrefixOfAnyWordInASentence("hellohello hellohellohello", "ell"));
            Console.WriteLine(CheckIfAWordOccursAsAPrefixOfAnyWordInASentence("i love eating burger", "burg"));
            Console.WriteLine(CheckIfAWordOccursAsAPrefixOfAnyWordInASentence("this problem is an easy problem", "pro"));
            Console.WriteLine(CheckIfAWordOccursAsAPrefixOfAnyWordInASentence("i am tired", "you"));
        }
        public static int CheckIfAWordOccursAsAPrefixOfAnyWordInASentence(string sentence, string searchWord)
        {
            var splitted = sentence.Split(' ');

            if (!splitted.Any(x => x.Contains(searchWord)))
                return -1;

            for (int i = 0; i < splitted.Length; i++)
                if (splitted[i].StartsWith(searchWord))
                    return i + 1;

            return -1;
        }
    }
}
