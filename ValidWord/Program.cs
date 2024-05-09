using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidWord("234Adas"));
            Console.WriteLine(ValidWord("b3"));
            Console.WriteLine(ValidWord("a3$e"));
            Console.WriteLine(ValidWord("UeU6"));
        }
        public static bool ValidWord(string word)
        {
            var vowels = new HashSet<char>()
            {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', };
            if (word.Length < 3)
                return false;
            if (word.Any(x => !char.IsLetterOrDigit(x)))
                return false;
            if (word.All(x => !vowels.Contains(x)))
                return false;
            foreach (char letter in word)
            {
                if (!char.IsDigit(letter) && !vowels.Contains(letter))
                    return true;
            }
            return false;
        }
    }
}
