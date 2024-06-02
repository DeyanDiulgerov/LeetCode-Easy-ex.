using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            ReverseString(new char[] { 'H', 'a', 'n', 'n', 'a', 'H' });
        }
        public static void ReverseString(char[] s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine(String.Join(",", s));
        }
    }
}
