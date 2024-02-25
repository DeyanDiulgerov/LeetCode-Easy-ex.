using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitTheArray(new int[] { 1, 1, 2, 2, 3, 4 }));
            Console.WriteLine(SplitTheArray(new int[] { 1, 1, 1, 1 }));
        }
        public static bool SplitTheArray(int[] nums)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], 1);
                else
                    map[nums[i]]++;
            }
            if (map.Count(x => x.Value == 1) % 2 != 0)
                return false;
            if (map.Any(x => x.Value > 2))
                return false;
            return true;
        }
    }
}
