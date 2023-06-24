using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthDistinctElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KthDistinctElement(new string[] { "d", "b", "c", "b", "c", "a" }, 2));
            Console.WriteLine(KthDistinctElement(new string[] { "aaa", "aa", "a" }, 1));
            Console.WriteLine(KthDistinctElement(new string[] { "a", "b", "a" }, 3));
        }

        public static string KthDistinctElement(string[] arr, int k)
        {
            var fullList = new List<string>(arr);
            var distinctList = new List<string>();

            foreach (var item in arr.Distinct())
            {
                distinctList.Add(item);
                fullList.Remove(item);
            }

            for (int i = 0; i < distinctList.Count(); i++)
            {
                if (fullList.Contains(distinctList[i]))
                {
                    distinctList.Remove(distinctList[i]);
                    i--;
                }
            }

            if (distinctList.Count < k)
                return "";
            else
                return distinctList[k - 1];
        }
    }
}
