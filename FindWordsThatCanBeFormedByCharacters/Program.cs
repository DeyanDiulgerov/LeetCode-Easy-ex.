using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWordsThatCanBeFormedByCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindWordsThatCanBeFormedByCharacters(new string[] { "cat", "bt", "hat", "tree" }, "atach"));
            Console.WriteLine(FindWordsThatCanBeFormedByCharacters(new string[] { "hello", "world", "leetcode" }, "welldonehoneyr"));
        }

        public static int FindWordsThatCanBeFormedByCharacters(string[] words, string chars)
        {
            string permChars = chars;
            int result = 0;

            for (int i = 0; i < words.Length; i++)
            {
                bool isGoodString = true;

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (chars.Contains(words[i][j]))
                    {
                        var index = chars.IndexOf(words[i][j]);
                        chars = chars.Remove(index, 1);
                    }
                    else
                    {
                        isGoodString = false;
                        break;
                    }
                }
                if (isGoodString)
                    result += words[i].Length;

                chars = permChars;
            }
            return result;
        }
    }
}
