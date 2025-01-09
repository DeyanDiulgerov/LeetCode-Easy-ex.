using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberofOperationstoMakeElementsinArrayDistinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberofOperationstoMakeElementsinArrayDistinct(new int[] { 5, 5 }));
            Console.WriteLine(MinimumNumberofOperationstoMakeElementsinArrayDistinct(new int[] { 1, 2, 3, 4, 2, 3, 3, 5, 7 }));
            Console.WriteLine(MinimumNumberofOperationstoMakeElementsinArrayDistinct(new int[] { 4, 5, 6, 4, 4 }));
            Console.WriteLine(MinimumNumberofOperationstoMakeElementsinArrayDistinct(new int[] { 6, 7, 8, 9 }));
        }

        public static int MinimumNumberofOperationstoMakeElementsinArrayDistinct(int[] nums)
        {
            int count = 0;
            for (int l = 0; l < nums.Count(); l += 3)
            {
                var newList = new List<int>();
                var set = new HashSet<int>();

                for (int r = l; r < nums.Count(); r++)
                    newList.Add(nums[r]);

                if (newList.Count == new HashSet<int>(newList).Count())
                    break;
                count++;
            }
            return count;
        }
    }
}
