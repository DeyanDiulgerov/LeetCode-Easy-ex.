using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseStringII("abcdefg", 3));
            Console.WriteLine(ReverseStringII("abcdefg", 8));
            Console.WriteLine(ReverseStringII("abcdefg", 2));
            Console.WriteLine(ReverseStringII("abcd", 2));
        }
        // Two-Pointers
        public static string ReverseStringII2P(string s, int k)
        {
            char[] charS = s.ToCharArray();
            if(k > charS.Length)
                Swap(0, charS.Length - 1);
            else
            {
                for(int i = 0; i < charS.Length; i += k * 2)
                {
                    if(i + k - 1 < charS.Length)
                        Swap(i, i + k - 1);
                    else
                        Swap(i, charS.Length - 1);
                }
            }
            return String.Join("", charS);
            void Swap(int left, int right)
            {
                while(left < right)
                {
                    char temp = charS[left];
                    charS[left] = charS[right];
                    charS[right] = temp;
                    left++;
                    right--;
            }
        }
        public static string ReverseStringII(string s, int k)
        {
            for (int i = 0; i < s.Length; i += k * 2)
            {
                var reversed = "";
                var test = "";

                if (i + k < s.Length)
                    for (int j = i; j < i + k; j++)
                        test += s[j];
                else
                    for (int j = i; j < s.Length; j++)
                        test += s[j];

                for (int r = test.Length - 1; r >= 0; r--)
                    reversed += test[r];

                if (k < s.Length && i + k < s.Length)
                    s = s.Remove(i, k);
                else if (k < s.Length && i + k >= s.Length)
                    s = s.Remove(i, s.Length - i);
                else
                    s = s.Remove(i, s.Length);


                s = s.Insert(i, reversed);
            }
            return s;
        }
    }
}
