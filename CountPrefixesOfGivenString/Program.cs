using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPrefixesOfGivenString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPrefixesOfGivenString(new string[] { "feh", "w", "w", "lwd", "c", "s", "vk",
                "zwlv", "n", "w", "sw", "qrd", "w", "w", "mqe", "w", "w", "w",
                "gb", "w", "qy", "xs", "br", "w", "rypg", "wh", "g", "w", "w",
                "fh", "w", "w", "sccy" }, "w"));
            Console.WriteLine(CountPrefixesOfGivenString(new string[] { "a", "b", "c", "ab", "bc", "abc" }, "abc"));
            Console.WriteLine(CountPrefixesOfGivenString(new string[] { "a", "a" }, "aa"));
        }

        public static int CountPrefixesOfGivenString(string[] words, string s)
        {
            bool isCount = false;
            int counter = 0;

            foreach (var item in words)
            {
                if (item.Length > s.Length)
                    continue;

                var length = Math.Min(item.Length, s.Length);

                for (int i = 0; i < length; i++)
                {

                    if (item[i] == s[i])
                        isCount = true;
                    else
                    {
                        isCount = false;
                        break;
                    }
                }
                if (isCount)
                    counter++;
            }

            return counter;
        }
    }
}
