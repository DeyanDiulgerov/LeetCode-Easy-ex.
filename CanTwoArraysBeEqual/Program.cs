using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTwoArraysBeEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanTwoArraysBeEqual(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 1, 3 }));
            Console.WriteLine(CanTwoArraysBeEqual(new int[] { 7 }, new int[] { 7 }));
            Console.WriteLine(CanTwoArraysBeEqual(new int[] { 3, 7, 9 }, new int[] { 3, 7, 11 }));
        }

        public static bool CanTwoArraysBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);

            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != arr[i])
                    return false;
            }

            return true;
        }
    }
}
