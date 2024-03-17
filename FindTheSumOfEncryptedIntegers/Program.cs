using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSumOfEncryptedIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheSumOfEncryptedIntegers(new int[] { 1, 2, 3 }));
            Console.WriteLine(FindTheSumOfEncryptedIntegers(new int[] { 10, 21, 31 }));
        }
        public static int FindTheSumOfEncryptedIntegers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                string strNum = nums[i].ToString();
                string decrypted = "";
                int max = 0;
                for (int j = 0; j < strNum.Length; j++)
                    max = Math.Max(max, strNum[j] - 48);
                for (int j = 0; j < strNum.Length; j++)
                    decrypted += max.ToString();

                nums[i] = int.Parse(decrypted);
            }
            return nums.Sum();
        }
    }
}
