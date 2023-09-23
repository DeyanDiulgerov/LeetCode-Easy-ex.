using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumIndexSumOfTwoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MinimumIndexSumOfTwoLists(new string[] { "Shogun", "Piatti", "Tapioca Express", "Burger King", "KFC" },
               new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" })));
            Console.WriteLine(String.Join(",", MinimumIndexSumOfTwoLists(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
                new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" })));
            Console.WriteLine(String.Join(",", MinimumIndexSumOfTwoLists(new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" },
                new string[] { "KFC", "Shogun", "Burger King" })));
            Console.WriteLine(String.Join(",", MinimumIndexSumOfTwoLists(new string[] { "happy", "sad", "good" },
                new string[] { "sad", "happy", "good" })));
        }
        public static string[] MinimumIndexSumOfTwoLists(string[] list1, string[] list2)
        {
            var wordAndIndexDict = new Dictionary<string, int>();

            for (int i = 0; i < list1.Length; i++)
            {
                if (list1.Contains(list1[i]) && list2.Contains(list1[i]))
                {
                    var commonIndex = 0;
                    var index1 = Array.IndexOf(list1, list1[i]);
                    var index2 = Array.IndexOf(list2, list1[i]);
                    commonIndex = index1 + index2;

                    if (!wordAndIndexDict.ContainsKey(list1[i]))
                        wordAndIndexDict.Add(list1[i], commonIndex);
                }
            }

            var allRestaurants = new List<string>();
            var minIndex = wordAndIndexDict.Values.OrderBy(x => x).First();

            foreach (var kvp in wordAndIndexDict.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (kvp.Value == minIndex)
                    allRestaurants.Add(kvp.Key);
            }

            return allRestaurants.ToArray();
        }
    }
}
