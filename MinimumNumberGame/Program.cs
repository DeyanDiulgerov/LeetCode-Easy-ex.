using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", new int[] { 5, 4, 2, 3 }));
            Console.WriteLine(String.Join(",", new int[] { 2, 5 }));
        }
        public static int[] MinimumNumberGame(int[] nums)
        {
            int[] resultArr = new int[nums.Length];
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i += 2)
            {
                resultArr[i] = nums[i + 1];
                resultArr[i + 1] = nums[i];
            }
            return resultArr;
        }
    }
}
