using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CircularSentence("leetcode exercises sound delightful"));
            Console.WriteLine(CircularSentence("eetcode"));
            Console.WriteLine(CircularSentence("Leetcode is cool"));
        }

        public static bool CircularSentence(string sentence)
        {
            if (sentence.All(x => x != ' '))
            {
                if (sentence[0] != sentence[sentence.Length - 1])
                    return false;
                else
                    return true;
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                if (i == sentence.Length - 1)
                {
                    if (sentence[i] != sentence[0])
                        return false;
                }
                else if (sentence[i] == ' ')
                {
                    if (sentence[i - 1] != sentence[i + 1])
                        return false;
                }
            }

            return true;
        }
    }
}
