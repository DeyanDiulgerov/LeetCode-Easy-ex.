using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestEnglishLetterInUpperAndLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreatestEnglishLetterInUpperAndLowerCase("lEeTcOdE"));
            Console.WriteLine(GreatestEnglishLetterInUpperAndLowerCase("arRAzFif"));
            Console.WriteLine(GreatestEnglishLetterInUpperAndLowerCase("AbCdEfGhIjK"));
        }

        public static string GreatestEnglishLetterInUpperAndLowerCase(string s)
        {
            var listedS = new List<string>();
            foreach (var letter in s)
                listedS.Add(letter.ToString());
            listedS.Sort();

            for (int i = listedS.Count() - 1; i >= 0; i--)
            {
                if (listedS.Contains(listedS[i].ToString().ToLower())
                 && listedS.Contains(listedS[i].ToString().ToUpper()))
                    return listedS[i].ToUpper();
            }

            return "";
        }
    }
}
