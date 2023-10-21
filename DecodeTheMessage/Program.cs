using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeTheMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeTheMessage(
                "the quick brown fox jumps over the lazy dog",
                 "vkbs bs t suepuv"));
            Console.WriteLine(DecodeTheMessage(
                "eljuxhpwnyrdgtqkviszcfmabo",
                 "zwx hnfx lqantp mnoeius ycgk vcnjrdb"));
        }

        public static string DecodeTheMessage(string key, string message)
        {
            var hashed = key.ToHashSet();
            var listed = new List<char>(hashed);
            var letterAndDecoded = new Dictionary<char, char>();
            char letter = 'a';
            listed.Remove(' ');

            for (int i = 0; i < listed.Count(); i++)
            {
                letterAndDecoded.Add(listed[i], letter);
                letter++;
            }
            letterAndDecoded.Add(' ', ' ');

            string result = "";
            for (int i = 0; i < message.Length; i++)
                result += letterAndDecoded[message[i]];

            return result;
        }
    }
}
