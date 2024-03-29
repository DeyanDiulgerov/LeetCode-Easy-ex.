using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 1, 2, 3 };
            var array2 = new int[] { 4, 3, 2, 1 };
            var array3 = new int[] { 9 };
            var array4 = new int[] { 9, 9 };
            var array5 = new int[] { 0 };
            var array6 = new int[] { 9, 9, 9, 9, 9 };
            var array7 = new int[] { 4, 9 };

            Console.WriteLine(String.Join(",", PlusOne(array1)));
            Console.WriteLine(String.Join(",", PlusOne(array2)));
            Console.WriteLine(String.Join(",", PlusOne(array3)));
            Console.WriteLine(String.Join(",", PlusOne(array4)));
            Console.WriteLine(String.Join(",", PlusOne(array5)));
            Console.WriteLine(String.Join(",", PlusOne(array6)));
            Console.WriteLine(String.Join(",", PlusOne(array7)));
        }

        public static int[] PlusOne(int[] digits)
        {
            if(digits.All(x => x == 9))
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }
            else
            {
                int i = digits.Length - 1;
                while (i >= 0 && digits[i] == 9)
                {
                    digits[i] = 0;
                    i--;
                }
                digits[i] += 1;
            }
            return digits;
        }
    }
}
