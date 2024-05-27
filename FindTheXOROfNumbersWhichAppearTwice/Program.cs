using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheXOROfNumbersWhichAppearTwice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheXOROfNumbersWhichAppearTwice(new int[] { 1, 2, 1, 3 }));
            Console.WriteLine(FindTheXOROfNumbersWhichAppearTwice(new int[] { 1, 2, 3 }));
            Console.WriteLine(FindTheXOROfNumbersWhichAppearTwice(new int[] { 1, 2, 2, 1 }));
        }
        public static int FindTheXOROfNumbersWhichAppearTwice(int[] nums)
        {
            var set = new HashSet<int>();
            int res = 0;
            foreach (int num in nums)
            {
                if (set.Add(num) == false)
                    res ^= num;
            }
            return res;
        }
    }
}
