using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSimilarItems
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var item1 in items1)
            {
                dictionary.Add(item1[0], item1[1]);
            }

            foreach (var item2 in items2)
            {
                if (!dictionary.ContainsKey(item2[0]))
                {
                    dictionary.Add(item2[0], item2[1]);
                }
                else
                    dictionary[item2[0]] += item2[1];
            }

            var retList = new List<IList<int>>();

            foreach (var item in dictionary.OrderBy(x => x.Key))
            {
                retList.Add(new List<int>() { item.Key, item.Value });
            }

            return retList;
        }
    }
}
