using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCostOfBuyingCandiesWithDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumCostOfBuyingCandiesWithDiscount(new int[] { 6, 5, 7, 9, 2, 2 }));
            Console.WriteLine(MinimumCostOfBuyingCandiesWithDiscount(new int[] { 3, 3, 3, 1 }));
            Console.WriteLine(MinimumCostOfBuyingCandiesWithDiscount(new int[] { 1, 2, 3 }));
            Console.WriteLine(MinimumCostOfBuyingCandiesWithDiscount(new int[] { 5, 5 }));
        }
        public static int MinimumCostOfBuyingCandiesWithDiscount(int[] cost)
        {
            if (cost.Length <= 2)
                return cost.Sum();

            var listed = new List<int>(cost);
            listed.Sort();
            listed.Reverse();

            Console.WriteLine(String.Join(",", listed));

            var sum = 0;
            bool minus = false;

            for (int i = 0; i < listed.Count(); i++)
            {
                if (listed.Count() == 1)
                {
                    sum += listed[i];
                    break;
                }

                for (int j = i + 1; j < i + 2; j++)
                {
                    sum += listed[i];
                    sum += listed[j];

                    for (int k = j + 1; k < listed.Count(); k++)
                    {
                        if (listed[i] + listed[j] >= listed[k])
                        {
                            listed.Remove(listed[k]);
                            minus = true;
                            break;
                        }
                    }

                    listed.Remove(listed[j]);
                    listed.Remove(listed[i]);
                    if (minus)
                    {
                        i--;
                        minus = false;
                    }
                }
            }

            return sum;
        }
    }
}
