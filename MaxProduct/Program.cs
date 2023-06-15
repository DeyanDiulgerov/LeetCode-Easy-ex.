using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProduct(new int[] { 3, 4, 5, 2 }));
            Console.WriteLine(MaxProduct(new int[] { 1, 5, 4, 5 }));
            Console.WriteLine(MaxProduct(new int[] { 3, 7 }));
        }

        public static int MaxProduct(int[] nums)
        {
            var listedNums = new List<int>(nums);
            listedNums.Sort();

            var highest = listedNums.Last();
            listedNums.Remove(highest);
            var secondHighest = listedNums.Last();

            return (highest - 1) * (secondHighest - 1);
        }
    }
}
