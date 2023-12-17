using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDistanceBetweeSameLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckDistanceBetweeSameLetters("abaccb",
                new int[] { 1, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
            Console.WriteLine(CheckDistanceBetweeSameLetters("aa",
               new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        }

        public static bool CheckDistanceBetweeSameLetters(string s, int[] distance)
        {
            Dictionary<char, int> letterAndDistanceMap = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!letterAndDistanceMap.ContainsKey(s[i]))
                    letterAndDistanceMap.Add(s[i], i);
                else // Contains
                    letterAndDistanceMap[s[i]] = i - letterAndDistanceMap[s[i]] - 1;
            }
            for (int i = 0; i < distance.Length; i++)
            {
                char letter = Convert.ToChar(i + 97);

                if (!letterAndDistanceMap.ContainsKey(letter))
                    continue;
                else
                {
                    if (letterAndDistanceMap[letter] != distance[i])
                        return false;
                }
            }
            return true;
        }
    }
}
