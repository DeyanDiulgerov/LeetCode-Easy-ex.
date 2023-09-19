using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageOfLetterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PercentageOfLetterInString("foobar", 'o'));
            Console.WriteLine(PercentageOfLetterInString("jjjj", 'k'));
            Console.WriteLine(PercentageOfLetterInString("sgawtb", 's'));
        }

        public static int PercentageOfLetterInString(string s, char letter)
        {
            if (!s.Contains(letter))
                return 0;

            double count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == letter)
                    count++;
            }

            return (int)Math.Floor((count / s.Length) * 100);
        }
    }
}
