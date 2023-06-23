using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 5));
            Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 2));
            Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 7));
        }

        public static int SearchInsertPosition(int[] nums, int target)
        {
            bool isBigger = false;
            int maxNum = 0;
            var listedNums = new List<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return listedNums.IndexOf(target);
                if (nums[i] < target)
                    isBigger = true;
                else
                {
                    isBigger = false;
                    maxNum = nums[i];
                    break;
                }
            }

            if (isBigger)
            {
                listedNums.Insert(listedNums.Count() - 1, target);
                return listedNums.Count() - 1;
            }
            else
                return listedNums.IndexOf(maxNum);
        }
    }
}
