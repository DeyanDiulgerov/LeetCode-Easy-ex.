using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceRecordI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StudentAttendanceRecordI("LALL"));
            Console.WriteLine(StudentAttendanceRecordI("PPALLP"));
            Console.WriteLine(StudentAttendanceRecordI("PPALLL"));
        }
        // NEW
        public bool StudentAttendanceRecordITWO(string s)
        {
            if(s.Contains("LLL")) 
                return false;
            if(s.Count(x => x == 'A') >= 2)
                return false;
            return true;
        }
        public static bool StudentAttendanceRecordI(string s)
        {
            if (s.Count(x => x == 'A') >= 2)
                return false;

            var test = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                    test += s[i];
                else
                    test = "";

                if (test.Count(x => x == 'L') >= 3)
                    return false;
            }

            return true;
        }
    }
}
