using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseVowelsOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowelsOfAString("c#dc"));
            Console.WriteLine(ReverseVowelsOfAString(".,"));
            Console.WriteLine(ReverseVowelsOfAString("leetcode"));
            Console.WriteLine(ReverseVowelsOfAString("hello"));
        }

        public static string ReverseVowelsOfAString(string s)
        {
            var allVowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            if (s.Count(x => allVowels.Contains(x)) <= 1)
                return s;

            var left = 0;
            var right = s.Length - 1;

            for (int i = 0; i < s.Length / 2; i++)
            {
                while (!allVowels.Contains(s[left]))
                    left++;
                while (!allVowels.Contains(s[right]))
                    right--;

                if (left >= right || left == s.Length - 1 || right == 0)
                    break;
                var permLeft = s[left].ToString();
                var permRight = s[right].ToString();

                s = s.Remove(left, 1);
                s = s.Insert(left, permRight);
                s = s.Remove(right, 1);
                s = s.Insert(right, permLeft);

                left++;
                right--;
            }

            return s;
        }
    }
}
