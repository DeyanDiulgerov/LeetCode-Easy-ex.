using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RestoreString("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }));
            Console.WriteLine(RestoreString("abc", new int[] { 0, 1, 2 }));
        }


        public static string RestoreString(string s, int[] indices)
        {
            if (s == null || s == String.Empty)
                return s;
            else if (s.Length == 1)
                return s;

            var charArray = new char[indices.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[indices[i]] = s[i];
                Console.WriteLine(String.Join(",", charArray));
            }

            return String.Join("", charArray);
        }
    }
}
