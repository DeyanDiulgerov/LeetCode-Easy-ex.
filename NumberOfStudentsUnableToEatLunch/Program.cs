using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStudentsUnableToEatLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfStudentsUnableToEatLunch(
                new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                new int[] { 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 }));

            Console.WriteLine(NumberOfStudentsUnableToEatLunch(
                new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }));
            Console.WriteLine(NumberOfStudentsUnableToEatLunch(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }));
        }

        public static int NumberOfStudentsUnableToEatLunch(int[] students, int[] sandwiches)
        {
            var queueStudents = new Queue<int>(students);
            var sstackSandwiches = new Queue<int>(sandwiches);

            while (true)
            {
                if (queueStudents.Count() == 0 || queueStudents.All(x => x != sstackSandwiches.Peek()))
                    break;

                var firstStudent = queueStudents.Peek();
                var firstSandwich = sstackSandwiches.Peek();

                queueStudents.Dequeue();

                if (firstSandwich == firstStudent)
                    sstackSandwiches.Dequeue();
                else
                    queueStudents.Enqueue(firstStudent);
            }

            return queueStudents.Count();
        }
    }
}
