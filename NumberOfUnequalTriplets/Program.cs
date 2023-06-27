using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfUnequalTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", NumberOfUnequalTriplets(new int[] { 4, 4, 2, 4, 3 })));
            Console.WriteLine(String.Join(",", NumberOfUnequalTriplets(new int[] { 1, 1, 1, 1, 1 })));
        }

        public static int NumberOfUnequalTriplets(int[] nums)
        {
            var retList = new List<List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        var newList = new List<int>();

                        if (nums[i] != nums[j] && nums[i] != nums[k] && nums[j] != nums[k])
                        {
                            newList.Add(nums[i]);
                            newList.Add(nums[j]);
                            newList.Add(nums[k]);
                        }
                        if (newList.Count() > 0)
                            retList.Add(newList);
                    }
                }
            }

            return retList.Count();
        }
    }
}
