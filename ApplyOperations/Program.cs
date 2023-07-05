using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ApplyOperations(new int[] { 1, 2, 2, 1, 1, 0 })));
            Console.WriteLine(String.Join(",", ApplyOperations(new int[] { 0, 1 })));
        }

        public static int[] ApplyOperations(int[] nums)
        {
            var listed = new List<int>(nums);

            for (int i = 0; i < listed.Count(); i++)
            {
                for (int j = i + 1; j < listed.Count(); j++)
                {
                    if (listed[i] == listed[j])
                    {
                        var index = listed.IndexOf(listed[i]);
                        var ourNum = listed[i];
                        Console.WriteLine(String.Join(",", listed));

                        ourNum *= 2;
                        listed.RemoveRange(i, 1);
                        Console.WriteLine(String.Join(",", listed));
                        listed.Insert(i, ourNum);
                        Console.WriteLine(String.Join(",", listed));
                        listed[j] = 0;
                        Console.WriteLine(String.Join(",", listed));

                        break;
                    }
                    else
                        break;
                }
            }

            var count = listed.Where(x => x == 0).Count();
            listed.RemoveAll(x => x == 0);

            for (int i = 0; i < count; i++)
            {
                listed.Add(0);
            }

            return listed.ToArray();
        }
    }
}
