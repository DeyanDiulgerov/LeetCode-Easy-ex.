using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDiffrentIntegersInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfDiffrentIntegersInAString("239370688023611040705962469696782" +
                "8762752651982730115221690437821508229419410771541532394006597463715513" +
                "74172585243255905722447881511655738026039043221122757966357104684584228170" +
                "42817495711100769742649719898936071371404562543469556334554460578237387573231498" +
                "56858154529105301197388177242583658641529908583934918768953462557716z974380204299529" +
                "4464628808417333470104757418893620132484514911017671613026704167443823760803873443" +
                "15194398281913442386095675303991893168463597662565073712405306206971028642387923502899" +
                "784505091626970689486047226467391745905303365104750615210945038505984535367069826952" +
                "12493902968251702853203929616930291257062173c79487281900662343830648295410"));
            Console.WriteLine(NumberOfDiffrentIntegersInAString("a123bc34d8ef34"));
            Console.WriteLine(NumberOfDiffrentIntegersInAString("leet1234code234"));
            Console.WriteLine(NumberOfDiffrentIntegersInAString("a1b01c001"));
        }
        public static int NumberOfDiffrentIntegersInAString(string word)
        {
            if (word.All(x => char.IsDigit(x)))
                return 1;

            var hashSet = new HashSet<int>();
            var bigNumbers = new HashSet<string>();
            string newDigit = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                    newDigit += word[i];
                else
                {
                    if (newDigit.Length >= 10)
                    {
                        bigNumbers.Add(newDigit);
                        newDigit = "";
                    }

                    if (newDigit != "")
                    {
                        hashSet.Add(int.Parse(newDigit));
                        newDigit = "";
                    }
                }
            }
            if (newDigit.Length >= 10)
            {
                bigNumbers.Add(newDigit);
                newDigit = "";
            }
            if (newDigit != "")
            {
                hashSet.Add(int.Parse(newDigit));
                newDigit = "";
            }

            return hashSet.Count() + bigNumbers.Count();
        }
    }
}
