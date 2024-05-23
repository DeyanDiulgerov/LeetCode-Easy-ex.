using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicateII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicateII(new int[] { 1, 2, 3, 1 }, 3));
            Console.WriteLine(ContainsDuplicateII(new int[] { 1, 0, 1, 1 }, 1));
            Console.WriteLine(ContainsDuplicateII(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
        }

        public static bool ContainsDuplicateII(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
                else
                {
                    if(Math.Abs(map[nums[i]] - i) <= k)
                        return true;
                    map[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
