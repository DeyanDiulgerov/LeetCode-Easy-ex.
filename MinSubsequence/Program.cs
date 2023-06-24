using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MinSubsequence(new int[] { 4, 3, 10, 9, 8 })));
            Console.WriteLine(String.Join(",", MinSubsequence(new int[] { 4, 4, 7, 6, 7 })));
        }

        public static IList<int> MinSubsequence(int[] nums)
        {
            int biggest = 0;
            var listNums = new List<int>(nums);
            var retList = new List<int>();

            while (retList.Sum() <= listNums.Sum())
            {
                biggest = listNums.Max();
                retList.Add(biggest);
                listNums.Remove(biggest);
            }

            return retList;
        }
    }
}
