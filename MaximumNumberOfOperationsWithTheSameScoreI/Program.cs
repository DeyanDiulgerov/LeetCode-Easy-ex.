using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfOperationsWithTheSameScoreI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumNumberOfOperationsWithTheSameScoreI(new int[] { 1, 1, 1, 1, 1, 1 }));
            Console.WriteLine(MaximumNumberOfOperationsWithTheSameScoreI(new int[] { 3, 2 }));
            Console.WriteLine(MaximumNumberOfOperationsWithTheSameScoreI(new int[] { 3, 2, 1, 4, 1 }));
            Console.WriteLine(MaximumNumberOfOperationsWithTheSameScoreI(new int[] { 3, 2, 1, 4, 5 }));
            Console.WriteLine(MaximumNumberOfOperationsWithTheSameScoreI(new int[] { 3, 2, 6, 1, 4 }));
        }
        public static int MaximumNumberOfOperationsWithTheSameScoreI(int[] nums)
        {
            int sum = nums[0] + nums[1];
            int count = 1;
            if (nums.Count() == 2)
                return 1;
            int left = 2, right = 3;
            while (right < nums.Length)
            {
                if (nums[left] + nums[right] != sum)
                    return count;
                left += 2;
                right += 2;
                count++;
            }
            return count;
        }
    }
}
