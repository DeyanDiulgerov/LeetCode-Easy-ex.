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
            var result = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                var newList = new List<int>();
                var text = "";
                int counter = 0;

                for (int j = i; j < nums.Length - 1; j++)
                {
                    if (j == i)
                        newList.Add(nums[j]);

                    if (nums[j] == nums[j + 1] - 1)
                    {
                        newList.Add(nums[j + 1]);
                        counter++;
                    }
                    else
                    {
                        if (newList.Count() > 1)
                        {
                            text += newList.First();
                            text += "->";
                            text += newList.Last();
                        }
                        else if (newList.Count() == 1)
                            text += newList.First();

                        break;
                    }
                    //Console.WriteLine(String.Join(",", newList));
                }
                i += counter;
                if (i != nums.Length - 1)
                    result.Add(text);
                else
                {
                    if (newList.Count() < 2)
                        result.Add(nums[i].ToString());
                    else if (newList.Count() >= 2)
                    {
                        text += newList.First();
                        text += "->";
                        text += newList.Last();
                        result.Add(text);
                    }
                }
            }
            return result;
        }
    }
}
