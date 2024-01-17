using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 })));
            Console.WriteLine(String.Join(",", SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 })));
        }

        public static IList<string> SummaryRanges(int[] nums)
        {
            if (nums.Length == 1)
                return new List<string>() { nums[0].ToString() };

            var resultList = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                string text = "";

                if(i == nums.Length - 1)
                {
                    if (nums[i - 1] != nums[i] - 1)
                        text = $"{nums[i]}";
                }
                else
                {
                    int permNumI = nums[i];
                    int j = i + 1;
                    while (j < nums.Length && nums[j] == nums[i] + 1)
                    {
                        i++;
                        j++;
                    }
                    j--;

                    if (permNumI == nums[j])
                        text = $"{permNumI}";
                    else
                        text = $"{permNumI}->{nums[j]}";

                    i = j;

                }
                resultList.Add(text);
            }
            return resultList;
        }
    }
}
