using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeNumber(121));
            Console.WriteLine(PalindromeNumber(-121));
            Console.WriteLine(PalindromeNumber(10));
        }

        public static bool PalindromeNumber(int x)
        {
            string str = x.ToString();
            int left = 0, right = str.Length - 1;
            while(left < right)
            {
                if(str[left] != str[right])
                    break;
                left++;
                right--;
            }
            return left >= right;
        }
    }
}
