using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWhetherTwoStringAreAlmolstEquivalent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckWhetherTwoStringAreAlmolstEquivalent(
                "bddhdfcdihfehbehfeiccehhchbibiggifcbgieedgfhggebcbeeddfdfiehcigdfcccdhgchbbfheddbdbiifeeiieg",
                "cdecdhhfgdieiifhhifffcgddeehgbciceggedbdggbigiieidgcceccgfhiecdefdhighbfdcdbgcfddeebbgibcihe"));
            Console.WriteLine(CheckWhetherTwoStringAreAlmolstEquivalent("zzzyyy", "iiiiii"));
            Console.WriteLine(CheckWhetherTwoStringAreAlmolstEquivalent("aaaa", "bccb"));
            Console.WriteLine(CheckWhetherTwoStringAreAlmolstEquivalent("abcdeef", "abaaacc"));
            Console.WriteLine(CheckWhetherTwoStringAreAlmolstEquivalent("cccddabba", "babababab"));
        }

        public static bool CheckWhetherTwoStringAreAlmolstEquivalent(string word1, string word2)
        {
            var usedLetter = new List<char>();

            for (int i = 0; i < word1.Length; i++)
            {
                if (usedLetter.Contains(word1[i]))
                    continue;

                int counter = word1.Where(x => x == word1[i]).Count();
                int twoCounter = word2.Where(x => x == word1[i]).Count();



                if (Math.Abs(counter - twoCounter) < 4)
                    usedLetter.Add(word1[i]);
                else if (Math.Abs(twoCounter - counter) >= 4)
                    return false;
                else
                    return false;
            }

            for (int i = 0; i < word2.Length; i++)
            {
                if (usedLetter.Contains(word2[i]))
                    continue;

                int counter = word1.Where(x => x == word2[i]).Count();
                int twoCounter = word2.Where(x => x == word2[i]).Count();

                if (Math.Abs(twoCounter) - Math.Abs(counter) < 4)
                    usedLetter.Add(word2[i]);
                else
                    return false;
            }

            return true;
        }
    }
}
