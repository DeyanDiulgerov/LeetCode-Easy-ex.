using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommonCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindCommonCharacters(
                new string[] { "cool", "lock", "cook" })));
            Console.WriteLine(String.Join(",", FindCommonCharacters(
                new string[] { "bella", "label", "roller" })));
        }

        public static IList<string> FindCommonCharacters(string[] words)
        {
            var result = new List<string>();
            for (int i = 0; i < words[0].Length; i++)
            {
                if (words.All(x => x.Contains(words[0][i])))
                {
                    result.Add(words[0][i].ToString());
                    for (int j = 1; j < words.Length; j++)
                        words[j] = words[j].Remove(words[j].IndexOf(words[0][i]), 1);
                }
            }
            return result;
        }
    }
}
