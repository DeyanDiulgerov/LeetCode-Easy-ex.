using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KItemsWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KItemsWithMaximumSum(3, 2, 0, 2));
            Console.WriteLine(KItemsWithMaximumSum(3, 2, 0, 4));
        }

        public static int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k)
        {
            var allNums = new List<int>();
            for (int i = 0; i < numOnes; i++)
                allNums.Add(1);
            for (int i = 0; i < numZeros; i++)
                allNums.Add(0);
            for (int i = 0; i < numNegOnes; i++)
                allNums.Add(-1);

            allNums.Sort();
            allNums.Reverse();

            var sum = 0;

            for (int i = 0; i < k; i++)
                sum += allNums[i];

            return sum;
        }
    }
}
