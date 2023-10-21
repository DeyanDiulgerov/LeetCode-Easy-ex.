using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReformatPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReformatPhoneNumber("1-23-45 6"));
            Console.WriteLine(ReformatPhoneNumber("123 4-567"));
            Console.WriteLine(ReformatPhoneNumber("123 4-5678"));
        }

        public static string ReformatPhoneNumber(string number)
        {
            var onlyNums = "";
            var result = "";

            for (int i = 0; i < number.Length; i++)
                if (char.IsDigit(number[i]))
                    onlyNums += number[i];

            for (int i = 0; i < onlyNums.Length; i += 3)
            {
                var lastIndex = onlyNums.Length - 1;

                if (onlyNums.Length - i == 2)
                {
                    result += onlyNums[lastIndex - 1];
                    result += onlyNums[lastIndex];
                    break;
                }
                else if (onlyNums.Length - i == 4)
                {
                    result += onlyNums[lastIndex - 3];
                    result += onlyNums[lastIndex - 2];
                    result += '-';
                    result += onlyNums[lastIndex - 1];
                    result += onlyNums[lastIndex];
                    break;
                }

                var newNums = "";

                for (int j = i; j < i + 3; j++)
                    newNums += onlyNums[j];

                result += newNums + "-";
            }

            result = result.TrimEnd('-');
            return result;
        }
    }
}
