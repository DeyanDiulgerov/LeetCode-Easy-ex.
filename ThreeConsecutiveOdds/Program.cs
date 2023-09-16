using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeConsecutiveOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeConsecutiveOdds(new int[] { 1, 2, 1, 1 }));
            Console.WriteLine(ThreeConsecutiveOdds(new int[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }));
            Console.WriteLine(ThreeConsecutiveOdds(new int[] { 2, 6, 4, 1 }));
        }

        public static bool ThreeConsecutiveOdds(int[] arr)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                var testList = new List<int>();

                for (int j = i; j < i + 3; j++)
                {
                    if (arr[j] % 2 != 0)
                        testList.Add(arr[j]);
                }

                if (testList.Count() == 3)
                    return true;
            }

            return false;
        }
    }
}
