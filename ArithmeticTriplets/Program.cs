using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArithmeticTriplets(new int[] { 0, 1, 4, 6, 7, 10 }, 3));
            Console.WriteLine(ArithmeticTriplets(new int[] { 4, 5, 6, 7, 8, 9 }, 2));
        }


        public static int ArithmeticTriplets(int[] nums, int diff)
        {
            var resultList = new List<List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if ((i < j && j < k) && nums[j] - nums[i] == diff && nums[k] - nums[j] == diff)
                        {
                            var newArray = new int[] { i, j, k };
                            resultList.Add(newArray.ToList());
                        }
                    }
                }
            }

            return resultList.Count();
        }
    }
}
