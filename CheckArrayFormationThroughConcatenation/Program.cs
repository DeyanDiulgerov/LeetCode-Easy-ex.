using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckArrayFormationThroughConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArrayFormationThroughConcatenation(new int[] { 99, 1 },
                new int[][] { new int[] { 9 }, new int[] { 91 } }));
            Console.WriteLine(CheckArrayFormationThroughConcatenation(new int[] { 15, 88 },
                new int[][] { new int[] { 88 }, new int[] { 15 } }));
            Console.WriteLine(CheckArrayFormationThroughConcatenation(new int[] { 49, 18, 16 },
                new int[][] { new int[] { 16, 18, 49 } }));
            Console.WriteLine(CheckArrayFormationThroughConcatenation(new int[] { 91, 4, 64, 78 },
                new int[][] { new int[] { 78 }, new int[] { 4, 64 }, new int[] { 91 } }));
        }

        public static bool CheckArrayFormationThroughConcatenation(int[] arr, int[][] pieces)
        {
            var listed = new List<int>(arr);
            foreach (var item in pieces)
            {
                foreach (var piece in item)
                {
                    if (!listed.Contains(piece))
                        return false;
                }
            }

            var strArr = string.Join(string.Empty, arr);
            var total = "";

            for (int i = 0; i < pieces.Length; i++)
            {
                var strTemp = string.Join(string.Empty, pieces[i]);

                if (!strArr.Contains(strTemp))
                    return false;

                total += strTemp;
            }

            return total.Length == strArr.Length;
        }
    }
}
