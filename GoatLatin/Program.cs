using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GoatLatin("Each word consists of lowercase and uppercase letters only"));
            Console.WriteLine(GoatLatin("I speak Goat Latin"));
            Console.WriteLine(GoatLatin("The quick brown fox jumped over the lazy dog"));
        }

        public static string GoatLatin(string sentence)
        {
            var result = "";
            var splitted = sentence.Split(' ');
            var allVowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < splitted.Count(); i++)
            {
                if (!allVowels.Contains(splitted[i][0]))
                {
                    var letter = splitted[i][0];
                    splitted[i] = splitted[i].Remove(0, 1);
                    splitted[i] += letter;
                }
                splitted[i] += "ma";

                for (int j = 0; j <= i; j++)
                    splitted[i] += 'a';

                result += splitted[i] + ' ';
            }

            result = result.TrimEnd(' ');
            return result;
        }
    }
}
