using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber_FindNonRepeatingElement
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SingleNumber(new int[] { 2, 2, 1 })));
            Console.WriteLine(String.Join(",", SingleNumber(new int[] { 4, 1, 2, 1, 2 })));
            Console.WriteLine(String.Join(",", SingleNumber(new int[] { 1 })));
            Console.WriteLine(String.Join(",", SingleNumber(new int[] { 1, 1, 2, 2, 3, 4, 5, 4, 5 })));
        }

        public static int SingleNumber(int[] nums)
        {
             var seen = new HashSet<int>();
             foreach(int num in nums)
             {
                 if(seen.Contains(num))
                     seen.Remove(num);
                 else
                     seen.Add(num);
             }
             return seen.First();
    }
    }
}
