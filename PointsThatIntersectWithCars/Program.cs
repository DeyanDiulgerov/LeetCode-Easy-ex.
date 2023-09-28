using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsThatIntersectWithCars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = new List<IList<int>>();
            input1.Add(new List<int>() { 3, 6 });
            input1.Add(new List<int>() { 1, 5 });
            input1.Add(new List<int>() { 4, 7 });

            var input2 = new List<IList<int>>();
            input2.Add(new List<int>() { 1, 3 });
            input2.Add(new List<int>() { 5, 8 });

            Console.WriteLine(PointsThatIntersectWithCars(input1));
            Console.WriteLine(PointsThatIntersectWithCars(input2));
        }

        public static int PointsThatIntersectWithCars(IList<IList<int>> nums)
        {
            var allPoints = new HashSet<int>();

            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = nums[i][0]; j <= nums[i][1]; j++)
                    allPoints.Add(j);
            }

            //Console.WriteLine(String.Join(",", allPoints));
            return allPoints.Count();
        }
    }
}
