using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPrefixDivisibleBy5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", BinaryPrefixDivisibleBy5(new int[] { 0, 1, 1 })));
            Console.WriteLine(String.Join(",", BinaryPrefixDivisibleBy5(
                new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1,
                    1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 })));
            Console.WriteLine(String.Join(",", BinaryPrefixDivisibleBy5(new int[] { 1, 1, 1 })));
        }

        public static IList<bool> BinaryPrefixDivisibleBy5(int[] nums)
        {
            int num = 0;
            var result = new List<bool>();

            for (int i = 0; i < nums.Length; i++)
            {
                num = (num * 2 + nums[i]) % 10;
                if (num % 5 == 0)
                    result.Add(true);
                else
                    result.Add(false);
            }

            return result;
        }
    }
}
