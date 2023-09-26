using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangleTwoGetRow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", PascalsTriangleTwoGetRow(3)));
            Console.WriteLine(String.Join(",", PascalsTriangleTwoGetRow(0)));
            Console.WriteLine(String.Join(",", PascalsTriangleTwoGetRow(1)));
        }

        public static IList<int> PascalsTriangleTwoGetRow(int rowIndex)
        {
            var resultList = new List<List<int>>() { };
            resultList.Add(new List<int>() { 1 });
            if (rowIndex == 0) return resultList.First();

            resultList.Add(new List<int>() { 1, 1 });
            if (rowIndex == 1) return resultList.Last();

            resultList.Add(new List<int>() { 1, 2, 1 });
            if (rowIndex == 2) return resultList.Last();

            for (int i = 3; i <= rowIndex; i++)
            {
                var newList = new List<int>();
                newList.Add(1);

                for (int j = 1; j < i; j++)
                {
                    newList.Add(resultList[i - 1][j - 1] + resultList[i - 1][j]);
                }

                newList.Add(1);
                resultList.Add(newList);
            }

            return resultList[rowIndex];
        }
    }
}
