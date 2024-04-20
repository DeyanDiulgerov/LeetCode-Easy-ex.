using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanMakeArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CanMakeArithmeticProgression(new int[] { 3, 5, 1 })));
            Console.WriteLine(String.Join(",", CanMakeArithmeticProgression(new int[] { 1, 2, 4 })));
        }

        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            for(int i = 2; i < arr.Length; i++)
            {
                if(arr[i] - arr[i - 1] != diff)
                    return false;
            }
            return true;
        }
    }
}
