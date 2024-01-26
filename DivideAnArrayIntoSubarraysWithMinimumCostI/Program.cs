using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAnArrayIntoSubarraysWithMinimumCostI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivideAnArrayIntoSubarraysWithMinimumCostI(new int[] { 1, 2, 3, 12 }));
            Console.WriteLine(DivideAnArrayIntoSubarraysWithMinimumCostI(new int[] { 5, 4, 3 }));
            Console.WriteLine(DivideAnArrayIntoSubarraysWithMinimumCostI(new int[] { 10, 3, 1, 1 }));
        }
        public static int DivideAnArrayIntoSubarraysWithMinimumCostI(int[] nums)
        {
            int result = nums[0];
            var listed = new List<int>(nums);
            listed.Remove(listed[0]);
            result += listed.Min();
            listed.Remove(listed.Min());
            result += listed.Min();
            listed.Remove(listed.Min());

            return result;
        }
    }
}
