using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThirdMaximumNumber(new int[] { 3, 2, 1 }));
            Console.WriteLine(ThirdMaximumNumber(new int[] { 1, 2 }));
            Console.WriteLine(ThirdMaximumNumber(new int[] { 2, 2, 3, 1 }));
        }

        public static int ThirdMaximumNumber(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);
            var listed = new List<int>(hashSet);
            listed.Sort();

            if (listed.Count >= 3)
                return listed[listed.Count - 3];
            else
                return listed.Max();
        }
    }
}
