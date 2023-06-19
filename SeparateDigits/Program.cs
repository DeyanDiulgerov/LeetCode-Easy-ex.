using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SeparateDigits(new int[] { 13, 25, 83, 77 })));
            Console.WriteLine(String.Join(",", SeparateDigits(new int[] { 7, 1, 3, 9 })));
            Console.WriteLine(String.Join(",", SeparateDigits(new int[] { 11, 7, 1, 3, 9 })));
        }

        public static int[] SeparateDigits(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 10)
                {
                    var newNum = nums[i].ToString().ToCharArray();
                    for (int j = 0; j < newNum.Length; j++)
                    {
                        result.Add(newNum[j] - 48);
                    }
                }
                else
                    result.Add(nums[i]);
            }

            return result.ToArray();
        }
    }
}
