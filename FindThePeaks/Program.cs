using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePeaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindThePeaks(new int[] { 2, 4, 4 })));
            Console.WriteLine(String.Join(",", FindThePeaks(new int[] { 1, 4, 3, 8, 5 })));
        }

        public static IList<int> FindThePeaks(int[] mountain)
        {
            var peakList = new List<int>();
            for (int i = 1; i < mountain.Length - 1; i++)
            {
                if (mountain[i] > mountain[i + 1]
                 && mountain[i] > mountain[i - 1])
                    peakList.Add(i);
            }
            return peakList;
        }
    }
}
