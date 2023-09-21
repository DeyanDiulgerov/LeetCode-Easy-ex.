using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConsecutiveCharacters("cc"));
            Console.WriteLine(ConsecutiveCharacters("j"));
            Console.WriteLine(ConsecutiveCharacters("ccbccbb"));
            Console.WriteLine(ConsecutiveCharacters("leetcode"));
            Console.WriteLine(ConsecutiveCharacters("abbcccddddeeeeedcba"));
        }

        public static int ConsecutiveCharacters(string s)
        {
            int max = 0;
            var newMax = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                newMax = 1;

                while (i < s.Length - 1 && s[i] == s[i + 1])
                {
                    newMax++;
                    i++;
                }


                max = Math.Max(max, newMax);
            }
            max = Math.Max(max, newMax);

            return max;
        }
    }
}
