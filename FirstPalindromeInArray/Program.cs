using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPalindromeInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstPalindromeInArray(new string[] { "abc", "car", "ada", "racecar", "cool" }));
            Console.WriteLine(FirstPalindromeInArray(new string[] { "notapalindrome", "racecar" }));
            Console.WriteLine(FirstPalindromeInArray(new string[] { "def", "ghi" }));
        }
        // Two Pointer
        public string FirstPalindromeTwoPointer(string[] words)
        {
            foreach (string word in words)
            {
                int left = 0, right = word.Length - 1;
                bool isPalindrome = true;
                while (left < right)
                {
                    if (word[left] != word[right])
                    {
                        isPalindrome = false;
                        break;
                    }
                    right--;
                    left++;
                }
                if (isPalindrome)
                    return word;
            }
            return "";
        }
        public static string FirstPalindromeInArray(string[] words)
        {
            var reversed = "";
            for (int i = 0; i < words.Count(); i++)
            {
                reversed = "";
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    reversed += words[i][j];
                }
                if (reversed == words[i])
                    return reversed;
            }

            return "";
        }
    }
}
