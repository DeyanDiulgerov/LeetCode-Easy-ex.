using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitStringsBySeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SplitStringsBySeparator(
                new List<string>() { "one.two.three", "four.five", "six" }, '.')));

            Console.WriteLine(String.Join(",", SplitStringsBySeparator(
                new List<string>() { "$easy$", "$problem$" }, '$')));
        }

        public static List<string> SplitStringsBySeparator(IList<string> words, char separator)
        {
            var resultList = new List<string>();

            foreach (var word in words)
            {
                foreach (var item in word.Split(separator))
                {
                    if (item == "")
                        continue;
                    resultList.Add(item);
                }
            }

            return resultList;
        }
    }
}
