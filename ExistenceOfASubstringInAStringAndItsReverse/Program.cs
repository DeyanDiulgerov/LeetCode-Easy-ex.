using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistenceOfASubstringInAStringAndItsReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExistenceOfASubstringInAStringAndItsReverse("ausoee"));
            Console.WriteLine(ExistenceOfASubstringInAStringAndItsReverse("e"));
            Console.WriteLine(ExistenceOfASubstringInAStringAndItsReverse("leetcode"));
            Console.WriteLine(ExistenceOfASubstringInAStringAndItsReverse("abcba"));
            Console.WriteLine(ExistenceOfASubstringInAStringAndItsReverse("abcd"));
        }
        public static bool ExistenceOfASubstringInAStringAndItsReverse(string s)
        {
            if (s.Length == 1)
                return false;
            char[] charRev = s.ToCharArray();
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char temp = charRev[left];
                charRev[left] = charRev[right];
                charRev[right] = temp;
                left++;
                right--;
            }
            string reversed = String.Join("", charRev);
            Console.WriteLine($"NORMAL: {s}");
            Console.WriteLine($"REVERSED: {reversed}");
            string window = $"{s[0]}{s[1]}";
            if (reversed.Contains(window))
                return true;
            right = 2;
            while (right < s.Length)
            {
                window = window.Remove(0, 1);
                window += s[right];
                if (reversed.Contains(window))
                {
                    return true;
                }
                right++;
            }
            return false;
        }
    }
}
