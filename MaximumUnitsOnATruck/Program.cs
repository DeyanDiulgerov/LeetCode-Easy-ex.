using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumUnitsOnATruck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input3 = new int[][]
            {
                new int[] {2,1},
                new int[] {4,4},
                new int[] {3,1},
                new int[] {4,1},
                new int[] {2,4},
                new int[] {3,4},
                new int[] {1,3},
                new int[] {4,3},
                new int[] {5,3},
                new int[] {5,3},
            };

            var boxType3 = MaximumUnitsOnATruck(input3, 13);
            Console.WriteLine(boxType3);


            int[][] input2 = new int[][]
            {
                new int[] {5,10},
                new int[] {2,5},
                new int[] {4,7},
                new int[] {3,9},
            };

            var boxType2 = MaximumUnitsOnATruck(input2, 10);
            Console.WriteLine(boxType2);

            int[][] input1 = new int[][]
            {
                new int[] {1,3},
                new int[] {2,2},
                new int[] {3,1},
            };

            var boxType1 = MaximumUnitsOnATruck(input1, 4);
            Console.WriteLine(boxType1);


        }

        public static int MaximumUnitsOnATruck(int[][] boxTypes, int truckSize)
        {
            int sum = 0;

            foreach (var item in boxTypes.OrderByDescending(x => x[1]))
            {
                int numberOfBoxes = item[0];
                int unitsPerBox = item[1];

                var test = truckSize - numberOfBoxes;
                truckSize -= numberOfBoxes;

                if (truckSize <= 0)
                {
                    numberOfBoxes += test;
                    sum += unitsPerBox * numberOfBoxes;
                    break;
                }
                else
                    sum += unitsPerBox * numberOfBoxes;
            }

            return sum;
        }
    }
}
