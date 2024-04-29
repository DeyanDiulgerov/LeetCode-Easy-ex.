using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheIntegerAddedToArrayI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheIntegerAddedToArrayI(new int[] { 2, 6, 4 }, new int[] { 9, 7, 5 }));
            Console.WriteLine(FindTheIntegerAddedToArrayI(new int[] { 10 }, new int[] { 5 }));
            Console.WriteLine(FindTheIntegerAddedToArrayI(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }));
        }
        public static int FindTheIntegerAddedToArrayI(int[] nums1, int[] nums2)
            => nums2.Max() - nums1.Max();
    }
}
