using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfValidWordsInASentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfValidWordsInASentence(
                ". ! 7hk  al6 l! aon49esj35la k3 7u2tkh  7i9y5  !jyylhppd et v- h!ogsouv 5"));
            Console.WriteLine(NumberOfValidWordsInASentence("pencil-sharpener."));
            Console.WriteLine(NumberOfValidWordsInASentence("he bought 2 pencils, 3 erasers, and 1  pencil-sharpener."));
            Console.WriteLine(NumberOfValidWordsInASentence("cat and  dog"));
            Console.WriteLine(NumberOfValidWordsInASentence("!this  1-s b8d!"));
            Console.WriteLine(NumberOfValidWordsInASentence("alice and  bob are playing stone-game10"));
        }
        public static int NumberOfValidWordsInASentence(string sentence)
        {
            int countValid = 0;
            List<string> splitted = sentence.Split(' ').ToList();
            splitted.RemoveAll(x => x == "");
            Console.WriteLine(String.Join("$", splitted));

            for (int i = 0; i < splitted.Count(); i++)
            {
                if (splitted[i].Any(x => char.IsDigit(x)))
                    continue;
                if (splitted[i].Count(x => x == '-') > 1)
                    continue;
                if (splitted[i].Count(x => char.IsPunctuation(x) && x != '-') > 1)
                    continue;

                bool isValid = true;

                for (int j = 0; j < splitted[i].Length; j++)
                {
                    if (splitted[i][j] == '-')
                    {
                        int index = splitted[i].IndexOf('-');
                        if (index == 0 || index == splitted[i].Length - 1)
                        {
                            isValid = false;
                            break;
                        }
                        if (!char.IsLetter(splitted[i][j - 1]) || !char.IsLower(splitted[i][j - 1])
                         || !char.IsLetter(splitted[i][j + 1]) || !char.IsLower(splitted[i][j + 1]))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    else if (char.IsPunctuation(splitted[i][j]))
                    {
                        int punctIndex = splitted[i].IndexOf(splitted[i][j]);

                        if (punctIndex != splitted[i].Length - 1)
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                    countValid++;
            }
            return countValid;
        }
    }
}
