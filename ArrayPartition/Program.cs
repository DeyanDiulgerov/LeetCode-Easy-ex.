using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPartition
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ArrayPartition(new int[] { 1, 4, 3, 2 }));
            Console.WriteLine(ArrayPartition(new int[] { 6, 2, 6, 5, 1, 2 }));
        }

        public static int ArrayPartition(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i += 2)
                sum += nums[i];

            return sum;
        }
    }
}
