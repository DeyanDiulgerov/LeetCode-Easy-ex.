using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanMakeArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CanMakeArithmeticProgression(new int[] { 3, 5, 1 })));
            Console.WriteLine(String.Join(",", CanMakeArithmeticProgression(new int[] { 1, 2, 4 })));
        }

        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            var listed = new List<int>(arr);
            listed.Sort();

            int counter = 0;

            for (int i = 0; i < listed.Count(); i++)
            {
                if (i < listed.Count() - 1)
                    counter = listed[i + 1] - listed[i];

                for (int j = i + 1; j < listed.Count(); j++)
                {
                    if (listed[j] - listed[i] != counter)
                        return false;

                    i++;
                }
            }
            return true;
        }
    }
}
