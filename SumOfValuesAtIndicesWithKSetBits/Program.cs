using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfValuesAtIndicesWithKSetBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfValuesAtIndicesWithKSetBits(new List<int>() { 5, 10, 1, 5, 2 }, 1));
            Console.WriteLine(SumOfValuesAtIndicesWithKSetBits(new List<int>() { 4, 3, 2, 1 }, 2));
        }

        public static int SumOfValuesAtIndicesWithKSetBits(IList<int> nums, int k)
        {
            int sum = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                string binary = Convert.ToString(i, 2);
                var counter = 0;

                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                        counter++;
                }

                if (counter == k)
                    sum += nums[i];
            }

            return sum;
        }
    }
}
