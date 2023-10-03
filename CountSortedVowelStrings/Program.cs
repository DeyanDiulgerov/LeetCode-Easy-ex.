using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSortedVowelStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSortedVowelStrings(1));
            Console.WriteLine(CountSortedVowelStrings(2));
            Console.WriteLine(CountSortedVowelStrings(10));
            Console.WriteLine(CountSortedVowelStrings(33));
        }
        public static int CountSortedVowelStrings(int n)
        {
            return (n + 1) * (n + 2) * (n + 3) * (n + 4) / 24;
        }
    }
}
