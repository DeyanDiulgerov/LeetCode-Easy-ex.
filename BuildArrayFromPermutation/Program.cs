using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildArrayFromPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", BuildArrayFromPermutation(new int[] { 0, 2, 1, 5, 3, 4 })));
            Console.WriteLine(String.Join(",", BuildArrayFromPermutation(new int[] { 5, 0, 1, 2, 3, 4 })));
        }

        public static int[] BuildArrayFromPermutation(int[] nums)
        {
            var answer = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                answer.Add(nums[nums[i]]);
            }

            return answer.ToArray();
        }
    }
}
