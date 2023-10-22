using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongPasswordCheckerII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrongPasswordCheckerII("yvTY#@IB#*!hjrQt-TLW&z)$@!%Duqt&ToskxHgnybqpndMI+wP&fcemIk#@KnkMTaUkcIbncpTL!"));
            Console.WriteLine(StrongPasswordCheckerII("IloveLe3tcode!"));
            Console.WriteLine(StrongPasswordCheckerII("vpWkmkfSAcCLDBNRfH"));
            Console.WriteLine(StrongPasswordCheckerII("aouwqsxl5bdkjdarza5x6yzg3r86bjz1nhtew5m4o5kxo7joldoaobl5e8j6rbux5"));
            Console.WriteLine(StrongPasswordCheckerII("91235674706076507949"));
            Console.WriteLine(StrongPasswordCheckerII("Me+You--IsMyDream"));
            Console.WriteLine(StrongPasswordCheckerII("1aB!"));
        }

        public static bool StrongPasswordCheckerII(string password)
        {
            var allSpecialChars = new List<char>() { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };

            if (password.Length < 8)
                return false;
            if (!password.Any(x => char.IsUpper(x)))
                return false;
            if (!password.Any(x => char.IsLower(x)))
                return false;
            if (!password.Any(x => char.IsLetter(x)))
                return false;
            if (!password.Any(x => char.IsDigit(x)))
                return false;
            if (!password.Any(x => allSpecialChars.Contains(x)))
                return false;
            for (int i = 1; i < password.Length; i++)
                if (password[i] == password[i - 1])
                    return false;

            return true;
        }
    }
}
