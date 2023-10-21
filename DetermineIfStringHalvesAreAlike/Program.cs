using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineIfStringHalvesAreAlike
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetermineIfStringHalvesAreAlike("book"));
            Console.WriteLine(DetermineIfStringHalvesAreAlike("textbook"));
        }

        public static bool DetermineIfStringHalvesAreAlike(string s)
        {
            var half = s.Length / 2;
            var firstCounter = 0;
            var secondCounter = 0;
            var allVowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < half; i++)
                if (allVowels.Contains(s[i]))
                    firstCounter++;

            for (int i = half; i < s.Length; i++)
                if (allVowels.Contains(s[i]))
                    secondCounter++;

            if (firstCounter == secondCounter)
                return true;

            return false;
        }
    }
}
