using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidMountainArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidMountainArray(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Console.WriteLine(ValidMountainArray(new int[] { 2, 1 }));
            Console.WriteLine(ValidMountainArray(new int[] { 3, 5, 5 }));
            Console.WriteLine(ValidMountainArray(new int[] { 0, 3, 2, 1 }));
        }

        public static bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            var maxNum = arr.Max();
            var index = Array.IndexOf(arr, maxNum);

            if (index == arr.Length - 1 || index == 0)
                return false;

            for (int r = index; r < arr.Length - 1; r++)
                if (arr[r] <= arr[r + 1])
                    return false;

            for (int l = index; l >= 1; l--)
                if (arr[l - 1] >= arr[l])
                    return false;

            return true;
        }
    }
}
