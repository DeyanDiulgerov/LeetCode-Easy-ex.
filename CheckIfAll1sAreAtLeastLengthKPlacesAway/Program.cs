using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAll1sAreAtLeastLengthKPlacesAway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfAll1sAreAtLeastLengthKPlacesAway(new int[] { 0, 1, 0, 0, 1, 0, 0, 1 }, 2));
            Console.WriteLine(CheckIfAll1sAreAtLeastLengthKPlacesAway(new int[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2));
            Console.WriteLine(CheckIfAll1sAreAtLeastLengthKPlacesAway(new int[] { 1, 0, 0, 1, 0, 1 }, 2));
        }

        public static bool CheckIfAll1sAreAtLeastLengthKPlacesAway(int[] nums, int k)
        {
            int distance = 0;
            bool firstOneFound = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && firstOneFound)
                    distance++;
                if (nums[i] == 1 && firstOneFound)
                {
                    if (distance < k)
                        return false;

                    distance = 0;
                }
                else if (nums[i] == 1)
                    firstOneFound = true;
            }
            return true;
        }
    }
}
