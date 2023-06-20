using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNumbers(new int[] { 12, 345, 2, 6, 7896 }));
            Console.WriteLine(FindNumbers(new int[] { 555, 901, 482, 1771 }));
            Console.WriteLine(FindNumbers(new int[] { 12, 11, 53, 33, 33 }));
        }

        public static int FindNumbers(int[] nums)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var test = nums[i].ToString().ToCharArray();

                if (test.Length % 2 == 0)
                    counter++;
            }

            return counter;
        }
    }
}
