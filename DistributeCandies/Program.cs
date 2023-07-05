using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DistributeCandies(new int[] { 1, 1, 2, 2, 3, 3 }));
            Console.WriteLine(DistributeCandies(new int[] { 1, 1, 2, 3 }));
            Console.WriteLine(DistributeCandies(new int[] { 6, 6, 6, 6 }));
        }

        public static int DistributeCandies(int[] candyType)
        {
            int n = candyType.Length;
            int maxAllowed = n / 2;
            var collectedCandies = new List<int>();

            foreach (var candy in candyType)
            {
                if (!collectedCandies.Contains(candy))
                    collectedCandies.Add(candy);

                if (collectedCandies.Count() == maxAllowed)
                    break;
            }

            return collectedCandies.Count();
        }

    }
}
