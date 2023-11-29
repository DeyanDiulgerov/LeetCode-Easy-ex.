using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfArrayIsSortedAndRotated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfArrayIsSortedAndRotated(new int[] { 3, 4, 5, 1, 2 }));
            Console.WriteLine(CheckIfArrayIsSortedAndRotated(new int[] { 2, 1, 3, 4 }));
            Console.WriteLine(CheckIfArrayIsSortedAndRotated(new int[] { 1, 2, 3 }));
        }

        public static bool CheckIfArrayIsSortedAndRotated(int[] nums)
        {
            int n = nums.Length;
            var testList = new List<int>(nums);
            testList.Sort();

            for (int i = 0; i < n; i++)
            {
                var temp = testList.Last();
                for (int j = n - 1; j >= 1; j--)
                {
                    testList[j] = testList[j - 1];
                }
                testList[0] = temp;

                if (testList.SequenceEqual(nums))
                    return true;
            }

            return false;
        }
    }
}
