using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSumDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", LeftRightSumDifference(new int[] { 10, 4, 8, 3 })));
            Console.WriteLine(String.Join(",", LeftRightSumDifference(new int[] { 1 })));
        }

        public static int[] LeftRightSumDifference(int[] nums)
        {
            // Math.Abs(leftSum[i] - rightSum[i])

            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (i == 0)
                {
                    leftSum = 0;
                    for (int r = i + 1; r < nums.Length; r++)
                        rightSum += nums[r];
                }
                else if (i == nums.Length - 1)
                {
                    rightSum = 0;
                    for (int l = i - 1; l >= 0; l--)
                        leftSum += nums[l];
                }
                else
                {
                    for (int l = i - 1; l >= 0; l--)
                        leftSum += nums[l];

                    for (int r = i + 1; r < nums.Length; r++)
                        rightSum += nums[r];
                }

                result.Add(Math.Abs(leftSum - rightSum));
            }

            return result.ToArray();
        }
    }
}
