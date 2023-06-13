using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPalindromeInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstPalindromeInArray(new string[] { "abc", "car", "ada", "racecar", "cool" }));
            Console.WriteLine(FirstPalindromeInArray(new string[] { "notapalindrome", "racecar" }));
            Console.WriteLine(FirstPalindromeInArray(new string[] { "def", "ghi" }));
        }

        public static string FirstPalindromeInArray(string[] words)
        {
            var reversed = "";

            for (int i = 0; i < words.Count(); i++)
            {
                reversed = "";
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    reversed += words[i][j];
                }
                if (reversed == words[i])
                    return reversed;
            }

            return "";
        }
    }
}
