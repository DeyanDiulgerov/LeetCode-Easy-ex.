using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", NumberOfPairs(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(",", NumberOfPairs(new int[] { 1, 3, 2, 1, 3, 2, 2 })));
            Console.WriteLine(String.Join(",", NumberOfPairs(new int[] { 0, 0, 1, 1, 2, 2 })));
            Console.WriteLine(String.Join(",", NumberOfPairs(new int[] { 1, 1 })));
            Console.WriteLine(String.Join(",", NumberOfPairs(new int[] { 0 })));
        }

        public static int[] NumberOfPairs(int[] nums)
        {
            int pairCounter = 0;
            var unique = new HashSet<int>();

            foreach (var num in nums)
            {
                if (unique.Contains(num))
                {
                    pairCounter++;
                    unique.Remove(num);
                }
                else
                    unique.Add(num);
            }

            return new int[] { pairCounter, unique.Count() };
        }
    }
}
