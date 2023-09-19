using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllNumbersDisappearedInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindAllNumbersDisappearedInAnArray(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
            Console.WriteLine(String.Join(",", FindAllNumbersDisappearedInAnArray(new int[] { 1, 1 })));
        }

        public static IList<int> FindAllNumbersDisappearedInAnArray(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!nums.Contains(i + 1))
                    result.Add(i + 1);
            }

            return result;
        }
    }
}
