using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPairSumInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxPairSumInAnArray(new int[] { 31, 25, 72, 79, 74 }));
            Console.WriteLine(MaxPairSumInAnArray(new int[] { 51, 71, 17, 24, 42 }));
            Console.WriteLine(MaxPairSumInAnArray(new int[] { 1, 2, 3, 4 }));
        }
        public static int MaxPairSumInAnArray(int[] nums)
        {
            var allNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var sum = nums[i] + nums[j];

                    var Isplitted = nums[i].ToString();
                    var Jsplitted = nums[j].ToString();
                    Isplitted = String.Concat(Isplitted.OrderBy(c => c));
                    Jsplitted = String.Concat(Jsplitted.OrderBy(c => c));

                    if (Isplitted.Last() == Jsplitted.Last())
                        allNums.Add(sum);
                }
            }

            if (allNums.Count > 0)
            {
                allNums.Sort();
                return allNums.Last();
            }
            else
                return -1;
        }
    }
}
