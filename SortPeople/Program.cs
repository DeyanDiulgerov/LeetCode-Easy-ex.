using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortPeople(new string[] { "Mary", "John", "Emma" }, new int[] { 180, 165, 170 })));
            Console.WriteLine(String.Join(",", SortPeople(new string[] { "Alice", "Bob", "Bob" }, new int[] { 155, 185, 150 })));
            Console.WriteLine(String.Join(",", SortPeople(new string[] { "Alice", "Bob", "Bob" }, new int[] { 155, 150, 185 })));
        }

        public static string[] SortPeople(string[] names, int[] heights)
        {
            Array.Sort(heights, names);
            Array.Reverse(names);
            return names;
        }
    }
}
