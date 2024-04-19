using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInAStringIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWordsInAStringIII("Let's take LeetCode contest"));
            Console.WriteLine(ReverseWordsInAStringIII("God Ding"));
        }
        public static string ReverseWordsInAStringIII(string s)
        {
            string[] splitted = s.Split(' ');
            for(int i = 0; i < splitted.Count(); i++)
            {
                string swapped = Swap(splitted[i]);
                splitted[i] = swapped;
            }
            return String.Join(" ", splitted);
            string Swap(string word)
            {
                char[] charWord = word.ToCharArray();
                int left = 0, right = charWord.Length - 1;
                while(left < right)
                {
                    char temp = charWord[left];
                    charWord[left] = charWord[right];
                    charWord[right] = temp;
                    left++;
                    right--;
                }
                return String.Join("", charWord);
            }
        }
    }
}
