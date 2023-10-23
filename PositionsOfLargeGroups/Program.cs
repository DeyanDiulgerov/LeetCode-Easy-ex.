using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionsOfLargeGroups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input1 = PositionsOfLargeGroups("abbxxxxzzy");
            var input2 = PositionsOfLargeGroups("abc");
            var input3 = PositionsOfLargeGroups("abcdddeeeeaabbbcd");

            foreach (var item in input1)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input2)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input3)
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<int>> PositionsOfLargeGroups(string s)
        {
            var result = new List<IList<int>>();

            for (int i = 0; i < s.Length; i++)
            {
                var newList = new List<int>();
                int counter = 0;
                var endIndex = 0;

                for (int j = i; j < s.Length; j++)
                {
                    if (s[j] == s[i])
                        counter++;
                    else
                        break;

                    endIndex = j;
                }

                if (counter >= 3)
                {
                    newList.Add(i);
                    newList.Add(endIndex);
                    result.Add(newList);
                    i += counter - 1;
                }
            }

            return result;
        }
    }
}
