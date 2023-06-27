using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByParityTWO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortArrayByParityTWO(new int[] { 4, 2, 5, 7 })));
            Console.WriteLine(String.Join(",", SortArrayByParityTWO(new int[] { 2, 3 })));
        }

        public static int[] SortArrayByParityTWO(int[] nums)
        {
            var listedNums = new List<int>(nums);
            var retList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var num = 0;

                if (i % 2 == 0)
                {
                    num = listedNums.First(x => x % 2 == 0);
                    retList.Add(num);
                    listedNums.Remove(num);
                }
                else
                {
                    num = listedNums.First(x => x % 2 != 0);
                    retList.Add(num);
                    listedNums.Remove(num);
                }
            }

            return retList.ToArray();
        }
    }
}
