using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDistinctAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfDistinctAverages(new int[] { 9, 5, 7, 8, 7, 9, 8, 2, 0, 7 }));
            Console.WriteLine(NumberOfDistinctAverages(new int[] { 4, 1, 4, 0, 3, 5 }));
            Console.WriteLine(NumberOfDistinctAverages(new int[] { 1, 100 }));
        }

        public static int NumberOfDistinctAverages(int[] nums)
        {
            var distinctAverages = new List<double>();
            var listedNums = new List<int>(nums);
            listedNums.Sort();

            while (listedNums.Count() > 0)
            {
                var min = listedNums.First();
                var max = listedNums.Last();

                double sum = (min + max);
                double average = sum / 2;
                distinctAverages.Add(average);

                listedNums.Remove(min);
                listedNums.Remove(max);
            }

            return distinctAverages.Distinct().Count();
        }
    }
}
