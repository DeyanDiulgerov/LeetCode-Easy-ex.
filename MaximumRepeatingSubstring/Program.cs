using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumRepeatingSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumRepeatingSubstring("aaabaaaabaaabaaaabaaaabaaaabaaaaba", "aaaba"));
            Console.WriteLine(MaximumRepeatingSubstring("ababc", "ab"));
            Console.WriteLine(MaximumRepeatingSubstring("ababc", "ba"));
            Console.WriteLine(MaximumRepeatingSubstring("ababc", "ac"));
        }
        public static int MaximumRepeatingSubstring(string sequence, string word)
        {
            if (!sequence.Contains(word))
                return 0;

            int max = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                int counter = 0;
                var newWord = "";
                for (int j = i; j < sequence.Length; j++)
                    newWord += sequence[j];

                while (newWord.Contains(word))
                {
                    var index = newWord.IndexOf(word);
                    if (index == 0)
                    {
                        counter++;
                        newWord = newWord.Remove(index, word.Length);
                    }
                    else
                    {
                        max = Math.Max(max, counter);
                        counter = 0;

                        newWord = newWord.Remove(0, index);
                    }
                }
                max = Math.Max(max, counter);
            }

            return max;
        }
    }
}
