using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeXORedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", DecodeXORedArray(new int[] { 1, 2, 3 }, 1)));
            Console.WriteLine(String.Join(",", DecodeXORedArray(new int[] { 6, 2, 7, 3 }, 4)));
        }

        public static int[] DecodeXORedArray(int[] encoded, int first)
        {
            int n = encoded.Length + 1;
            var result = new int[n];
            result[0] = first;

            for (int i = 1; i < n; i++)
                result[i] = result[i - 1] ^ encoded[i - 1];

            return result;
        }
    }
}
