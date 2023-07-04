using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumberTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumberTwo(new int[] { 2, 2, 3, 2 }));
            Console.WriteLine(SingleNumberTwo(new int[] { 0, 1, 0, 1, 0, 1, 99 }));
        }

        public static int SingleNumberTwo(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i], 1);
                else
                    dictionary[nums[i]]++;
            }

            foreach (var kvp in dictionary.Where(x => x.Value == 1))
                return kvp.Key;

            return -1;
        }
    }
}
