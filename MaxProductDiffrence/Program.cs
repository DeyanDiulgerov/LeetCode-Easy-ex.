using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProductDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProductDiffrence(new int[] { 5, 6, 2, 7, 4 }));
            Console.WriteLine(MaxProductDiffrence(new int[] { 4, 2, 5, 9, 7, 4, 8 }));
        }

        public static int MaxProductDiffrence(int[] nums)
        {
            var resultList = new List<int>(nums);

            resultList.Sort();

            var firstLowest = resultList.First();
            resultList.Remove(firstLowest);
            var secondLowest = resultList.First();

            var firstHighest = resultList.Last();
            resultList.Remove(firstHighest);
            var secondHighest = resultList.Last();

            int sum = (firstHighest * secondHighest) - (firstLowest * secondLowest);

            return sum;
        }
    }
}
