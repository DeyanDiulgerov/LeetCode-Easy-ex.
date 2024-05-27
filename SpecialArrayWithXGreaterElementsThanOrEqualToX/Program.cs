using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialArrayWithXGreaterElementsThanOrEqualToX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpecialArrayWithXGreaterElementsThanOrEqualToX(new int[] { 3, 5 }));
            Console.WriteLine(SpecialArrayWithXGreaterElementsThanOrEqualToX(new int[] { 0, 0 }));
            Console.WriteLine(SpecialArrayWithXGreaterElementsThanOrEqualToX(new int[] { 0, 4, 3, 0, 4 }));
        }

        public static int SpecialArrayWithXGreaterElementsThanOrEqualToX(int[] nums)
        {
            int h = nums.Length + 1;
            while(h-- > 0)
                if(nums.Count(x => x >= h) == h)
                    break;
            return h;
        }
    }
}
