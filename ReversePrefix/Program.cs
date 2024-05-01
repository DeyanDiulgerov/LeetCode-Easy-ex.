using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversePrefix("abcdefd", 'd'));
            Console.WriteLine(ReversePrefix("xyxzxe", 'z'));
            Console.WriteLine(ReversePrefix("abcd", 'z'));
        }

        public static string ReversePrefix(string word, char ch)
        {
            int index = word.IndexOf(ch);
            char[] charW = word.ToCharArray();
            int left = 0, right = index;
            while(left < right)
            {
                char temp = charW[left];
                charW[left] = charW[right];
                charW[right] = temp;
                left++;
                right--;
            }
            return String.Join("", charW);
        }
    }
}
