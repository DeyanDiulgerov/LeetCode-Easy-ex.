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
            var allVowels = new List<char>()
            { 'a', 'e', 'i', 'o', 'u','A', 'E', 'I', 'O',  'U'};

            var charS = s.ToCharArray();
            int left = 0, right = charS.Length - 1;

            while (left < right)
            {
                while (left < charS.Length && !allVowels.Contains(charS[left]))
                    left++;
                while (right >= 0 && !allVowels.Contains(charS[right]))
                    right--;
                if (left >= right)
                    break;

                var temp = charS[left];
                charS[left] = charS[right];
                charS[right] = temp;
                left++;
                right--;
            }
            return String.Join("", charS);
        }
    }
}
