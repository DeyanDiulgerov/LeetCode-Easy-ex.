using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOnlyLetters("ab-cd"));
            Console.WriteLine(ReverseOnlyLetters("a-bC-dEf-ghIj"));
            Console.WriteLine(ReverseOnlyLetters("Test1ng-Leet=code-Q!"));
        }

        public static string ReverseOnlyLetters(string s)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                    counter++;
            }

            int n = 0;
            if (counter % 2 == 0)
                n = counter / 2;
            else
                n = (counter / 2) + 1;

            int left = 0;
            int right = s.Length - 1;

            for (int i = 0; i < n; i++)
            {
                if (left == s.Length - 1 || right == 0 || left == right)
                    break;

                while (!char.IsLetter(s[left]))
                    left++;
                while (!char.IsLetter(s[right]))
                    right--;

                var permLeft = s[left];
                var permRight = s[right];

                s = s.Remove(left, 1);
                s = s.Insert(left, permRight.ToString());
                s = s.Remove(right, 1);
                s = s.Insert(right, permLeft.ToString());

                left++;
                right--;
            }

            return s;
        }
    }
}
