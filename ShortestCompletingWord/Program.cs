using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCompletingWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShortestCompletingWord("1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" }));
            Console.WriteLine(ShortestCompletingWord("1s3 456", new string[] { "looks", "pest", "stew", "show" }));
        }
        public static string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var numsLicensePlate = "";
            words = words.OrderBy(x => x.Length).ToArray();

            for (int i = 0; i < licensePlate.Length; i++)
            {
                if (char.IsLetter(licensePlate[i]))
                    numsLicensePlate += licensePlate[i].ToString().ToLower();
            }

            var permLicensePlate = numsLicensePlate;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (numsLicensePlate.Contains(words[i][j]))
                        numsLicensePlate = numsLicensePlate.Remove(numsLicensePlate.IndexOf(words[i][j]), 1);
                }

                if (numsLicensePlate.Length == 0)
                    return words[i];
                else
                    numsLicensePlate = permLicensePlate;
            }

            return "TEST";
        }
    }
}
