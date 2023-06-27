using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWordsOnKeyboardRow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindWordsOnKeyboardRow(new string[] { "Hello", "Alaska", "Dad", "Peace" })));
            Console.WriteLine(String.Join(",", FindWordsOnKeyboardRow(new string[] { "omk" })));
            Console.WriteLine(String.Join(",", FindWordsOnKeyboardRow(new string[] { "asdf", "sfd" })));
        }

        public static string[] FindWordsOnKeyboardRow(string[] words)
        {
            var row1 = "qwertyuiop";
            var row2 = "asdfghjkl";
            var row3 = "zxcvbnm";
            bool isOnSameRow = true;

            var resultList = new List<string>();

            foreach (var item in words)
            {
                foreach (var letter in item.ToLower())
                {
                    if (!row1.Contains(letter))
                        isOnSameRow = false;
                }
                if (isOnSameRow)
                    resultList.Add(item);

                isOnSameRow = true;

                foreach (var letter in item.ToLower())
                {
                    if (!row2.Contains(letter))
                        isOnSameRow = false;
                }
                if (isOnSameRow)
                    resultList.Add(item);

                isOnSameRow = true;

                foreach (var letter in item.ToLower())
                {
                    if (!row3.Contains(letter))
                        isOnSameRow = false;
                }
                if (isOnSameRow)
                    resultList.Add(item);

                isOnSameRow = true;
            }

            return resultList.ToArray();
        }
    }
}
