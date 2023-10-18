using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestLetterGreaterThanTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSmallestLetterGreaterThanTarget(new char[] { 'c', 'f', 'j' }, 'a'));
            Console.WriteLine(FindSmallestLetterGreaterThanTarget(new char[] { 'c', 'f', 'j' }, 'c'));
            Console.WriteLine(FindSmallestLetterGreaterThanTarget(new char[] { 'x', 'x', 'y', 'y' }, 'z'));
        }

        public static char FindSmallestLetterGreaterThanTarget(char[] letters, char target)
        {
            Console.WriteLine(letters[0] - target);
            Console.WriteLine((letters[0] - 48) - (target - 48));
            Console.WriteLine(letters[1] - target);
            Console.WriteLine((letters[1] - 48) - (target - 48));

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] - target > 0)
                    return letters[i];
            }

            return letters[0];
        }
    }
}
