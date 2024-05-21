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
            StringBuilder sb = new StringBuilder();
            string shortest = strs.OrderBy(x => x.Length).First();
            for(int i = 0; i < shortest.Length; i++)
            {
                if(strs.Any(x => x[i] != shortest[i]))
                    break;
                sb.Append(shortest[i]);
            }
            return sb.ToString();
        }
    }
}
