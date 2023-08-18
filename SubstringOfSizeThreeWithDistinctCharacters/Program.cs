using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringOfSizeThreeWithDistinctCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubstringOfSizeThreeWithDistinctCharacters("xyzzaz"));
            Console.WriteLine(SubstringOfSizeThreeWithDistinctCharacters("aababcabc"));
            Console.WriteLine(SubstringOfSizeThreeWithDistinctCharacters("abcabcabcabcabc"));
        }

        public static int SubstringOfSizeThreeWithDistinctCharacters(string s)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < i + 2; j++)
                {
                    if (j <= s.Length - 2)
                    {
                        for (int k = j + 1; k < j + 2; k++)
                        {
                            if (s[i] != s[j] && s[i] != s[k] && s[j] != s[k])
                                counter++;
                        }
                    }
                }
            }
            return counter;
        }

    }
}
