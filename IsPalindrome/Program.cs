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
            string alphaNumeric = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                    alphaNumeric += s[i].ToString().ToLower();
            }

            int left = 0, right = alphaNumeric.Length - 1;
            while (left < right)
            {
                if (alphaNumeric[left] != alphaNumeric[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
        public static string IsPalindrome(string text)
        {
            var reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            if (reversed.ToLower() == text.ToLower())
                return $"The string {text} is Palindrome";
            else
                return $"The string {text} is NOT Palindrome";
        }

        public static bool IsPalindromeBool(string text)
        {
            var reversed = "";
            var newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetterOrDigit(text[i]))
                    newText += text[i];
            }
            text = newText;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(text[i]))
                    reversed += text[i];
            }

            if (reversed.ToLower() == text.ToLower())
                return true;
            else
                return false;
        }
    }
}
