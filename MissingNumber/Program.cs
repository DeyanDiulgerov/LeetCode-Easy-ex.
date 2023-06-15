using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array nums containing n distinct numbers in the range [0, n],
            //return the only number in the range that is missing from the array.

            var array1 = new int[] { 3, 0, 1 };
            var array2 = new int[] { 0, 1 };
            var array3 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            Console.WriteLine(MissingNumber(array1));
            Console.WriteLine(MissingNumber(array2));
            Console.WriteLine(MissingNumber(array3));
        }

        public static int MissingNumber(int[] nums)
        {
            // array from 0 to n;
            var list = new List<int>(nums);
            list.Sort();

            for (int i = 0; i < nums.Length; i++)
            {
                if (list[i] != i)
                {
                    return i;
                }
            }
            return list.Count();

        }
    }
}
