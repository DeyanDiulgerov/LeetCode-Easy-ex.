using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Largest_Element_in_a_Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KthLargest kth = new KthLargest(3, new int[] { 4, 5, 8, 2 });
            kth.Add(3);
            kth.Add(5);
            kth.Add(10);
            kth.Add(9);
            kth.Add(4);
        }
        public class KthLargest
        {
            List<int> dataSet;
            int index;
            public KthLargest(int k, int[] nums)
            {
                dataSet = new List<int>(nums);
                dataSet.Sort();
                index = k;
            }
            public int Add(int val)
            {

                int left = 0, right = dataSet.Count();
                int mid = 0;
                while (left < right)
                {
                    mid = left + (right - left) / 2;
                    if (dataSet[mid] <= val)
                        left = mid + 1;
                    else
                        right = mid;
                }
                dataSet.Insert(right, val);

                Console.WriteLine(String.Join(",", dataSet));
                Console.WriteLine(dataSet[dataSet.Count() - index]);
                return dataSet[dataSet.Count() - index];
            }
        }
    }
}
