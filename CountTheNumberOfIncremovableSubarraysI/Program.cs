using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheNumberOfIncremovableSubarraysI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountTheNumberOfIncremovableSubarraysI(new int[] { 2, 1, 1, 4 }));
            Console.WriteLine(CountTheNumberOfIncremovableSubarraysI(new int[] { 5, 8, 8 }));
            Console.WriteLine(CountTheNumberOfIncremovableSubarraysI(new int[] { 1, 2 }));
            Console.WriteLine(CountTheNumberOfIncremovableSubarraysI(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(CountTheNumberOfIncremovableSubarraysI(new int[] { 6, 5, 7, 8 }));
            Console.WriteLine(CountTheNumberOfIncremovableSubarraysI(new int[] { 8, 7, 6, 6 }));
        }
        public static int CountTheNumberOfIncremovableSubarraysI(int[] nums)
        {
            int n = nums.Length;
            List<int> listedNums = new List<int>(nums);
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                listedNums.RemoveAt(i);
                List<int> sortedList = new List<int>(listedNums);
                sortedList.Sort();
                HashSet<int> hashSet = new HashSet<int>(sortedList);

                /*Console.WriteLine(String.Join(",", listed));
                Console.WriteLine(String.Join(",", newList));
                Console.WriteLine(String.Join(",", hashSet));*/
                if (listedNums.SequenceEqual(sortedList)
                 && listedNums.SequenceEqual(hashSet))
                    counter++;

                int j = i;
                while (j < listedNums.Count() && listedNums.Count() >= 1)
                {
                    listedNums.RemoveAt(j);

                    sortedList = new List<int>(listedNums);
                    sortedList.Sort();
                    hashSet = new HashSet<int>(sortedList);

                    /*Console.WriteLine(String.Join(",", listed));
                    Console.WriteLine(String.Join(",", newList));
                    Console.WriteLine(String.Join(",", hashSet));*/

                    if (listedNums.SequenceEqual(sortedList)
                     && listedNums.SequenceEqual(hashSet))
                        counter++;
                }

                listedNums = new List<int>(nums);
            }
            return counter;
        }
    }
}
