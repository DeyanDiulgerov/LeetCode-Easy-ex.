using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastStoneWeight
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));
            Console.WriteLine(LastStoneWeight(new int[] { 1 }));
        }

        public static int LastStoneWeight(int[] stones)
        {
            var listed = new List<int>(stones);

            while (listed.Count() > 1)
            {
                int y = listed.Max();
                listed.Remove(y);
                int x = listed.Max();

                if (y == x)
                    listed.Remove(x);
                else
                {
                    listed.Remove(x);

                    var newStone = y - x;
                    listed.Add(newStone);
                }
            }

            if (listed.Count() >= 1)
                return listed.First();
            else
                return 0;
        }
    }
}
