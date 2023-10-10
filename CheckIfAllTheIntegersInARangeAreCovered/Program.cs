using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAllTheIntegersInARangeAreCovered
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfAllTheIntegersInARangeAreCovered
               (new int[][] { new int[] { 1, 50 } }, 1, 50));
            Console.WriteLine(CheckIfAllTheIntegersInARangeAreCovered
                (new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }, 2, 5));
            Console.WriteLine(CheckIfAllTheIntegersInARangeAreCovered
                (new int[][] { new int[] { 1, 10 }, new int[] { 10, 20 } }, 21, 21));
        }
        public static bool CheckIfAllTheIntegersInARangeAreCovered(int[][] ranges, int left, int right)
        {
            var allNums = new List<int>();
            var pairNums = new List<int>();

            for (int i = left; i <= right; i++)
                allNums.Add(i);

            foreach (var pair in ranges)
            {
                for (int i = pair[0]; i <= pair[1]; i++)
                    pairNums.Add(i);
            }

            allNums.Sort();
            pairNums = pairNums.Distinct().ToList();
            pairNums.Sort();

            bool isTrue = false;
            for (int i = 0; i < allNums.Count(); i++)
            {
                if (pairNums.Contains(allNums[i]))
                    isTrue = true;
                else
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue)
                return true;
            else
                return false;
        }
    }
}
