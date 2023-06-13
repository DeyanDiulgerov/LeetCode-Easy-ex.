using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumOfStrings(new string[] { "a", "abc", "bc", "d" }, "abc"));
            Console.WriteLine(NumOfStrings(new string[] { "a", "b", "c" }, "aaaaabbbbb"));
            Console.WriteLine(NumOfStrings(new string[] { "a", "a", "a" }, "ab"));
        }

        public static int NumOfStrings(string[] patterns, string word)
        {
            int counter = 0;

            for (int i = 0; i < patterns.Count(); i++)
            {
                if (word.Contains(patterns[i]))
                    counter++;
            }

            return counter;
        }
    }
}
