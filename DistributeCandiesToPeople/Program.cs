using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeCandiesToPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", DistributeCandiesToPeople(7, 4)));
            Console.WriteLine(String.Join(",", DistributeCandiesToPeople(10, 3)));
        }

        public static int[] DistributeCandiesToPeople(int candies, int num_people)
        {
            var resultArr = new int[num_people];
            int counter = 1;

            while (candies > 0)
            {
                for (int i = 0; i < num_people; i++)
                {
                    if (candies < counter)
                    {
                        resultArr[i] += candies;
                        candies = 0;
                        break;
                    }

                    resultArr[i] += counter;
                    candies -= counter;
                    counter++;

                    if (candies <= 0)
                        break;
                }
            }

            return resultArr;
        }
    }
}
