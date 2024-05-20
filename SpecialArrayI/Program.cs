using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialArrayI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpecialArrayI(new int[] { 1 }));
            Console.WriteLine(SpecialArrayI(new int[] { 2, 1, 4 }));
            Console.WriteLine(SpecialArrayI(new int[] { 4, 3, 1, 6 }));
        }
        public static bool SpecialArrayI(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] % 2 == 0 && nums[i + 1] % 2 == 0)
                    return false;
                else if (nums[i] % 2 != 0 && nums[i + 1] % 2 != 0)
                    return false;
            }
            return true;
        }
    }
}
