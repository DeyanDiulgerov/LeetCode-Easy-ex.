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
                return nums;
            else if (nums.Length == 1)
                return nums;
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j] && i != j)
                        {
                            var newNum = nums[j];
                            //Console.WriteLine(String.Join(", ", nums));
                            //nums = nums.Except(new int[] { nums[j] }).ToArray();
                            nums = nums.Where(x => x != nums[j]).ToArray();
                            nums = nums.Prepend(newNum).ToArray();
                            //Console.WriteLine(String.Join(", ", nums));
                            //Console.WriteLine($"K === {String.Join(", ", listNums)}");
                        }
                    }
                }

                var newList = new List<int>(nums);
                newList.Sort();
                //Console.WriteLine(String.Join(",", newList));
                //Console.WriteLine(String.Join(",", nums));
                return newList.ToArray();
            }
        }
    }
}
