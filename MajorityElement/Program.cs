using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 1, 1, 1, 2, 2, 3, 3, 3, 3 }));
            Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
            Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
            Console.WriteLine(MajorityElement(new int[] { 3, 2, 2, 1, 1, 1 }));
        }

        public static int MajorityElement(int[] nums)
        {
            var newMaxCounter = 0;
            bool isEnd = false;
            var dictionary = new Dictionary<int, int>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Count(); i++)
            {
                newMaxCounter = 0;
                var newNum = nums[i];

                while (newNum == nums[i])
                {
                    newMaxCounter++;

                    if (i < nums.Count() - 1)
                        i++;
                    else
                    {
                        isEnd = true;
                        break;
                    }
                }
                dictionary.Add(newNum, newMaxCounter);

                if (isEnd)
                    break;
                else
                    i--;
            }
            var element = dictionary.OrderByDescending(x => x.Value).First();

            return element.Key;
        }
    }
}
