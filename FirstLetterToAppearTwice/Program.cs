using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLetterToAppearTwice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstLetterToAppearTwice("abccbaacz"));
            Console.WriteLine(FirstLetterToAppearTwice("abcdd"));
        }

        public static char FirstLetterToAppearTwice(string s)
        {
            var allChars = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (allChars.Contains(s[i]))
                    return s[i];

                allChars.Add(s[i]);
            }

            return ' ';
        }
    }
}
