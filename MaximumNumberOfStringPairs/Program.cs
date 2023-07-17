using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfStringPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumNumberOfStringPairs(
                new string[] { "cd", "ac", "dc", "ca", "zz" }));

            Console.WriteLine(MaximumNumberOfStringPairs(
                new string[] { "ab", "ba", "cc" }));
        }

        public static int MaximumNumberOfStringPairs(string[] words)
        {
            int pairs = 0;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    var reversed = "";

                    for (int k = words[j].Length - 1; k >= 0; k--)
                        reversed += words[j][k];

                    if (words[i] == reversed)
                        pairs++;
                }
            }

            return pairs;
        }
    }
}
