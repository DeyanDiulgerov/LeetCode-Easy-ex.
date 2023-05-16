using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArray1 = new List<int>() { 1, 1, 2 };
            int[] array1 = new int[] { 1, 1, 2 };
            int[] array2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] array3 = new int[] { 1, 0, 0, 1, 2, 2, 2, 2, 3, 3 };
            int[] array4 = new int[] { 1, 0, 0, 1, 2, 2, 2, 2, 3, 3, 4, 4, 5, 6, 7, 8, 8, 8, 9, 8 };

            var k1 = RemoveDuplicates(array1);
            Console.WriteLine($"Count of Array1: {k1.Count()}");
            Console.WriteLine($"-{String.Join(",", k1)}\n");

            int[] k2 = RemoveDuplicates(array2);
            Console.WriteLine($"Count of Array2: {k2.Count()}");
            Console.WriteLine($"-{String.Join(",", k2)}\n");

            int[] k3 = RemoveDuplicates(array3);
            Console.WriteLine($"Count of Array3: {k3.Count()}");
            Console.WriteLine($"-{String.Join(",", k3)}\n");

            int[] k4 = RemoveDuplicates(array4);
            Console.WriteLine($"Count of Array4: {k4.Count()}");
            Console.WriteLine($"-{String.Join(",", k4)}\n");

        }

        public static int[] RemoveDuplicates(int[] nums)
        {
             if (nums.Length == 0)
                return null;
            else if (nums.Length == 1)
                return nums;
            else
            {
                var newList = new List<int>(nums);

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i != j && nums[i] == nums[j])
                        {
                            newList.RemoveAll(x => x == nums[j]);
                            newList.Add(nums[j]);
                        }
                    }
                }
                newList.Sort();
                nums = newList.ToArray();
                return nums;
        }
    }
}
