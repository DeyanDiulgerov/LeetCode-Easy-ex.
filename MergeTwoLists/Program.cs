using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split(',').ToList();
            var list2 = Console.ReadLine().Split(',').ToList();

            var reOrdered = new List<string>();

            for (int i = 0; i < list1.Count(); i++)
            {
                reOrdered.Add(list1[i]);
            }

            for (int i = 0; i < list2.Count(); i++)
            {
                reOrdered.Add(list2[i]);
            }

            reOrdered.Sort();
            Console.WriteLine($"[{String.Join(" ", reOrdered)}]");
        }
    }
}
