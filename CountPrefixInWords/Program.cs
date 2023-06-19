using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPrefixInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPrefixInWords(new string[]
            { "pay", "attention", "practice", "attend" }, "at"));
            Console.WriteLine(CountPrefixInWords(new string[]
            { "leetcode","win","loops","success" }, "code"));
        }

        public static int CountPrefixInWords(string[] words, string pref)
        {
            int counter = 0;

            foreach (var item in words)
            {
                if (item.StartsWith(pref))
                    counter++;
            }

            return counter;
        }
    }
}
