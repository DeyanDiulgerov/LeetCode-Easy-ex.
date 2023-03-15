using System.ComponentModel;
using System.Globalization;
using System;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given a sorted array of distinct integers and a target value,
             * return the index if the target is found.
             * If not, return the index where it would be if it were inserted in order.*/

            var nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            var target = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (nums[i] == target - 1)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }

            //Console.WriteLine(nums.Length);

        }
    }
}
