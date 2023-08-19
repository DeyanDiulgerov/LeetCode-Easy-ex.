using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RansomNote("aa", "ab"));
            Console.WriteLine(RansomNote("a", "b"));
            Console.WriteLine(RansomNote("aa", "aab"));
        }

        public static bool RansomNote(string ransomNote, string magazine)
        {
            var permNote = ransomNote;

            for (int i = 0; i < permNote.Length; i++)
            {
                if (magazine.Contains(permNote[i]))
                {
                    magazine = magazine.Remove(magazine.IndexOf(permNote[i]), 1);
                    ransomNote = ransomNote.Remove(ransomNote.IndexOf(permNote[i]), 1);
                }
            }

            if (ransomNote.Count() == 0)
                return true;
            else
                return false;
        }
    }
}
