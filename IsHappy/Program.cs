﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsHappy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write an algorithm to determine if a number n is happy.
            A happy number is a number defined by the following process:

        Starting with any positive integer, replace the number by the sum of the squares of its digits.
        Repeat the process until the number equals 1(where it will stay),
            or it loops endlessly in a cycle which does not include 1.
        Those numbers for which this process ends in 1 are happy.
        Return true if n is a happy number, and false if not.*/


            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsHappy(n));
        }

        public static bool IsHappy(int n)
        {
            //n = 19 so 1^2 + 9^2 == 82
            //repeat :
            //1^2 + 9^2 == 82
            //8^2 + 2^2 == 68
            //6^2 + 8^2 == 100
            //1^2 + 0^2 + 0^2 == 1
            //If n == 1 END.

            var seenNums = new List<int>();
            while (true)
            {
                string strN = n.ToString();
                int sum = 0;
                for (int i = 0; i < strN.Length; i++)
                {
                    int newNum = int.Parse(strN[i].ToString());
                    sum += newNum * newNum;
                }

                if (seenNums.Contains(sum))
                    return false;
                if (sum == 1)
                    return true;

                seenNums.Add(sum);
                n = sum;
            }
        }
    }
}
