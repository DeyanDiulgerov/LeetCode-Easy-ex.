using System;
using System.Collections.Generic;
using System.Linq;


namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            var target = int.Parse(Console.ReadLine());

            //int[] numss = { 3, 2, 4 };
             
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target && i != j)
                        {
                            int[] arr = { i, j };

                            Console.WriteLine(String.Join(",", arr));
                        }
                    }
                }  
        }
    }
}

/*Given an array of integers nums and an integer target,
 * return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.*/
