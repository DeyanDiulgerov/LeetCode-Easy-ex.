using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAlternatingSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestAlternatingSubarray(new int[] { 2, 3, 4, 3, 4 }));
            Console.WriteLine(LongestAlternatingSubarray(new int[] { 4, 5, 6 }));
        }

        public static int LongestAlternatingSubarray(int[] nums)
        {
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var newList = new List<int>();
                newList.Add(nums[i]);
                bool isOne = false;
                int counter = 1;
                int newI = 0;
                int newJ = 1;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    newList.Add(nums[j]);

                    if (counter == 0)
                        isOne = false;
                    else if (counter == 1)
                        isOne = true;

                    if (isOne && newList[newJ] - newList[newI] == 1)
                    {
                        max = Math.Max(max, newList.Count());
                        counter--;
                    }
                    else if (!isOne && newList[newJ] - newList[newI] == -1)
                    {
                        max = Math.Max(max, newList.Count());
                        counter++;
                    }
                    else
                        break;

                    newI++;
                    newJ++;
                }
            }

            if (max != 0)
                return max;
            else
                return -1;
        }
    }
}
