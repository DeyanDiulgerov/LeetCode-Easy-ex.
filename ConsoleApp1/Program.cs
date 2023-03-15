
namespace PalindromeNumber
{
    class Program
    {
        //Given an integer x, return true if x is a palindrome, and false otherwise.

        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            IsPalindrome(text);          
        }

        private static string IsPalindrome(string text)
        {
            while (text != "END")
            {
                string reversed = "";

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversed += text[i];
                }

                bool palindrome = reversed == text;
                Console.WriteLine(palindrome);

                text = Console.ReadLine();
            }

            return text;
        }
    }
}