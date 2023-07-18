using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSquaresOfSpecialElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfSquaresOfSpecialElement(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(SumOfSquaresOfSpecialElement(new int[] { 2, 7, 1, 19, 18, 3 }));
        }

        public static int SumOfSquaresOfSpecialElement(int[] nums)
        {
            int n = nums.Length;
            var allSpecialElements = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    allSpecialElements.Add(nums[i - 1] * nums[i - 1]);
            }

            return allSpecialElements.Sum();
        }
    }
}
