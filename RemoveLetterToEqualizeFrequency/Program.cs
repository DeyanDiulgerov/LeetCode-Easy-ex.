using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveLetterToEqualizeFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveLetterToEqualizeFrequency("abbcc"));
            Console.WriteLine(RemoveLetterToEqualizeFrequency("ddaccb"));
            Console.WriteLine(RemoveLetterToEqualizeFrequency("bac"));
            Console.WriteLine(RemoveLetterToEqualizeFrequency("abcc"));
            Console.WriteLine(RemoveLetterToEqualizeFrequency("aazz"));
        }
        public static bool RemoveLetterToEqualizeFrequency(string word)
        {
            var letterAndFrequencyMap = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (!letterAndFrequencyMap.ContainsKey(word[i]))
                    letterAndFrequencyMap.Add(word[i], 1);
                else
                    letterAndFrequencyMap[word[i]]++;
            }

            var allFrequencies = new List<int>();

            foreach (var kvp in letterAndFrequencyMap)
                allFrequencies.Add(kvp.Value);

            for (int i = 0; i < allFrequencies.Count(); i++)
            {
                var testFreq = allFrequencies[i] - 1;
                allFrequencies.RemoveAt(i);
                if (testFreq == 0)
                {
                    if (allFrequencies.All(x => x == allFrequencies.First()))
                        return true;
                }
                else
                {
                    if (allFrequencies.All(x => x == testFreq))
                        return true;
                }
                allFrequencies.Insert(i, testFreq + 1);
            }

            return false;
        }
    }
}
