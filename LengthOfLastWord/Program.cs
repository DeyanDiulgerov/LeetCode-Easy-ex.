using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("Hello World"));
            Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
            Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
        }

        public static int LengthOfLastWord(string s)
        {
            return s
                .TrimEnd(' ')
                .Split(' ')
                .Last()
                .Length;
        }
    }
}
