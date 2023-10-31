using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveOneElementToMakeTheArrayStrictlyIncreasing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveOneElementToMakeTheArrayStrictlyIncreasing(new int[] {
                42, 50, 54, 74, 84, 86, 88, 93, 104, 127, 143, 160, 164, 169, 170, 181, 209, 223,
                225, 231, 247, 257, 262, 274, 282, 306, 307, 320, 346, 357, 378, 381, 387, 392, 394,
                404, 423, 437, 444, 456, 476, 491, 507, 524, 527, 528, 537, 558, 566, 574, 169, 584,
                585, 609, 621, 626, 632, 644, 653, 661, 662, 670, 676, 698, 704, 710, 718, 719, 730,
                735, 737, 746, 748, 755, 776, 782, 785, 795, 802, 812, 822, 828, 863, 866, 870, 872,
                877, 899, 905, 909, 919, 929, 940, 944, 961, 963, 980, 981 }));
            Console.WriteLine(RemoveOneElementToMakeTheArrayStrictlyIncreasing(new int[] { 1, 1 }));
            Console.WriteLine(RemoveOneElementToMakeTheArrayStrictlyIncreasing(new int[] { 1, 2, 10, 5, 7 }));
            Console.WriteLine(RemoveOneElementToMakeTheArrayStrictlyIncreasing(new int[] { 2, 3, 1, 2 }));
            Console.WriteLine(RemoveOneElementToMakeTheArrayStrictlyIncreasing(new int[] { 1, 1, 1 }));
        }

        public static bool RemoveOneElementToMakeTheArrayStrictlyIncreasing(int[] nums)
        {
            if (nums.Length == 2)
                return true;

            var listed = new List<int>(nums);

            for (int i = 0; i < listed.Count(); i++)
            {
                var testItem = listed[i];
                listed.RemoveAt(i);
                bool isIncreasing = false;

                for (int j = 1; j < listed.Count(); j++)
                {
                    if (listed[j] > listed[j - 1])
                        isIncreasing = true;
                    else
                    {
                        isIncreasing = false;
                        break;
                    }
                }
                if (isIncreasing)
                    return true;

                listed.Insert(i, testItem);
            }

            return false;
        }
    }
}
