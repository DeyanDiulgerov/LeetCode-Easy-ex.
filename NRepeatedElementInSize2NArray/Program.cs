using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepeatedElementInSize2NArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NRepeatedElementInSize2NArray(new int[] { 1, 2, 3, 3 }));
            Console.WriteLine(NRepeatedElementInSize2NArray(new int[] { 2, 1, 2, 5, 3, 2 }));
            Console.WriteLine(NRepeatedElementInSize2NArray(new int[] { 5, 1, 5, 2, 5, 3, 5, 4 }));
        }

        public static int NRepeatedElementInSize2NArray(int[] nums)
        {
            int n = nums.Length / 2;
            //1 element of nums is repeated n times;

            var elementAndTimesShown = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!elementAndTimesShown.ContainsKey(nums[i]))
                    elementAndTimesShown.Add(nums[i], 1);
                else
                    elementAndTimesShown[nums[i]]++;
            }

            foreach (var kvp in elementAndTimesShown.OrderByDescending(x => x.Value))
            {
                if (kvp.Value == n)
                    return kvp.Key;
            }

            return 0;
        }
    }
}
