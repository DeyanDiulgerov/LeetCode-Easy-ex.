using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximizeSum(new int[] { 1, 2, 3, 4, 5 }, 3));
            Console.WriteLine(MaximizeSum(new int[] { 5, 5, 5 }, 2));
        }

        public static int MaximizeSum(int[] nums, int k)
        {
            Array.Sort(nums);
            var highest = nums.Last();
            var listed = new List<int>(nums);
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                listed.Remove(highest);
                sum += highest;
                highest++;
                listed.Add(highest);
            }

            return sum;
        }
    }
}
