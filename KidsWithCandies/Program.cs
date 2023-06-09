using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsWithCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3)));
            Console.WriteLine(String.Join(",", KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1)));
            Console.WriteLine(String.Join(",", KidsWithCandies(new int[] { 12, 1, 12 }, 10)));
        }


        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            List<int> sortedCandieList = new List<int>(candies);
            sortedCandieList.Sort();

            var biggestCandie = sortedCandieList.Last();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= biggestCandie)
                    result.Add(true);
                else
                    result.Add(false);

            }
            return result;
        }
    }
}
