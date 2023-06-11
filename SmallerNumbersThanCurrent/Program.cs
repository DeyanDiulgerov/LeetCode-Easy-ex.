using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNumbersThanCurrent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 })));
            Console.WriteLine(String.Join(",", SmallerNumbersThanCurrent(new int[] { 6, 5, 4, 8 })));
            Console.WriteLine(String.Join(",", SmallerNumbersThanCurrent(new int[] { 7, 7, 7, 7 })));
        }


        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[j] < nums[i])
                    {
                        counter++;
                    }
                }
                result[i] = counter;
            }

            return result;
        }
    }
}
