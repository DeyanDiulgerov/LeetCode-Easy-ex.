using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palindrome text is when the text is the exact same front to back as back to front
            // RADAR == RADAR

            Console.WriteLine($"\n\n\nWrite a program in C# Sharp to check whether a given string is Palindrome or not");
            Console.WriteLine($"--------------------------------------------------------------------------");
            Console.WriteLine($"We use ToLower so if the letters are the same it will count as Palindrome text");
            Console.WriteLine($"--------------------------------------------------------------------------\n");
            Console.WriteLine(IsPalindrome("Radar"));
            Console.WriteLine(IsPalindrome("RADAR"));
            Console.WriteLine(IsPalindrome("Eye"));
            Console.WriteLine(IsPalindrome("eye"));
            Console.WriteLine(IsPalindrome("texte"));
            Console.WriteLine(IsPalindrome("12321"));
            Console.WriteLine(IsPalindrome("123454321"));
            Console.WriteLine(IsPalindrome("1233333321"));
            Console.WriteLine(IsPalindrome("1234567"));
            Console.WriteLine($"----------------------------------------------------------------------------\n");

            Console.WriteLine($"If you wish you can add another text For Testing");
            Console.Write($"Your text is == ");
            var text = Console.ReadLine();
            Console.WriteLine(IsPalindrome(text));
        }
        // Two Pointer Approach
        public static bool IsPalindromeTwoPointer(string s)
        {
            List<char> charS = s.ToLower().ToList();
            charS.RemoveAll(x => !char.IsLetterOrDigit(x));
            int left = 0, right = charS.Count - 1;
            while(left < right)
            {
                if(charS[left] != charS[right])
                    break;
                left++;
                right--;
            }
            return left >= right;
        }
    }
}
