using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecompressRunLengthEncodedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",",
                DecompressRunLengthEncodedlist(new int[] { 1, 2, 3, 4 })));

            Console.WriteLine(String.Join(",",
                DecompressRunLengthEncodedlist(new int[] { 1, 1, 2, 3 })));
        }

        public static int[] DecompressRunLengthEncodedlist(int[] nums)
        {
            var allArrays = new List<List<int>>();
            var resultList = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                if (i < nums.Length - 1)
                {
                    var newList = new List<int>();
                    var freq = nums[i];
                    var value = nums[i + 1];

                    for (int j = 0; j < freq; j++)
                    {
                        newList.Add(value);
                    }

                    allArrays.Add(newList);
                }
            }

            foreach (var item in allArrays)
            {
                foreach (var num in item)
                {
                    resultList.Add(num);
                }
            }

            return resultList.ToArray();
        }
    }
}
