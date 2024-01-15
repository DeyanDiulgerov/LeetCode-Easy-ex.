using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            while (command != "End")
            {
                var strs = command.Split(',').ToArray();
                Console.WriteLine(LongestCommonPrefix(strs));
                command = Console.ReadLine();
            }
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string shortest = strs.OrderBy(x => x.Length).First();
            int indexCount = 0;
            string result = "";

            foreach (char letter in shortest)
            {
                if (strs.All(x => x[indexCount] == letter))
                    result += letter;
                else
                    break;

                indexCount++;
            }
            return result;
        }
    }
}
