using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDividingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SelfDividingNumbers(1, 22)));
            Console.WriteLine(String.Join(",", SelfDividingNumbers(47, 85)));
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            var resultList = new List<int>();

            for (int i = left; i <= right; i++)
            {
                bool isDivisable = true;

                if (i.ToString().Contains("0"))
                    continue;

                var str = i.ToString();

                for (int j = 0; j < str.Length; j++)
                {
                    if (i % (str[j] - 48) != 0)
                        isDivisable = false;
                }

                if (isDivisable)
                    resultList.Add(i);
            }
            return resultList;
        }
    }
}
