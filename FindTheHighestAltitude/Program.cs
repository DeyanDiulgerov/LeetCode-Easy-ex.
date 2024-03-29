﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheHighestAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheHighestAltitude(new int[] { -5, 1, 5, 0, -7 }));
            Console.WriteLine(FindTheHighestAltitude(new int[] { -4, -3, -2, -1, 4, 3, 2 }));
        }

        public static int FindTheHighestAltitude(int[] gain)
        {
            int n = gain.Length;
            var resultArr = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
                resultArr[i] = resultArr[i - 1] + gain[i - 1];

            return resultArr.Max();
        }
    }
}
