using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongPressedName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongPressedName("alex", "aaleexa"));
            Console.WriteLine(LongPressedName("rick", "kric"));
            Console.WriteLine(LongPressedName("xnhtq", "xhhttqq"));
            Console.WriteLine(LongPressedName("leelee", "lleeeeel"));
            Console.WriteLine(LongPressedName("leelee", "lleeelee"));
            Console.WriteLine(LongPressedName("alex", "aaleex"));
            Console.WriteLine(LongPressedName("saeed", "ssaaedd"));
        }
        public static bool LongPressedName(string name, string typed)
        {
            int left = 0, right = 0;

            while (left < name.Length && right < typed.Length)
            {
                int rCount = 0;
                int lCount = 0;
                if (name[left] != typed[right])
                    return false;

                while (right < typed.Length && name[left] == typed[right])
                {
                    right++;
                    rCount++;
                }
                if (right > 0)
                    right--;
                while (left < name.Length && name[left] == typed[right])
                {
                    left++;
                    lCount++;
                }
                if (lCount > rCount)
                    return false;

                right++;
                if (left >= name.Length)
                    break;

            }
            if (left >= name.Length && right >= typed.Length)
                return true;
            else
                return false;
        }
    }
}
