using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XorOperationInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XorOperationInAnArray(5, 0));
            Console.WriteLine(XorOperationInAnArray(4, 3));
        }
        public static int XorOperationInAnArray(int n, int start)
        {
            var nums = new int[n];

            for (int i = 0; i < n; i++)
                nums[i] = start + (2 * i);

            int xor = 0;

            for (int i = 0; i < nums.Length; i++)
                xor ^= nums[i];

            return xor;
        }
    }
}
