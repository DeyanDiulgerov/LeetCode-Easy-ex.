using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void MoveZeroes(int[] nums)
        {
            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    continue;

                nums[index] = nums[i];

                if (index != i)
                    nums[i] = 0;

                index++;
            }

            return;
        }
    }
}
