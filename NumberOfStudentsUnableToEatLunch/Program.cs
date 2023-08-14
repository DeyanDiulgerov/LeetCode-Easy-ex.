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
                if (queueStudents.Count() == 0)
                    break;

                var firstStudent = queueStudents.Peek();
                var firstSandwich = sstackSandwiches.Peek();

                if (queueStudents.All(x => x != firstSandwich))
                    break;

                if (firstSandwich == firstStudent)
                {
                    queueStudents.Dequeue();
                    sstackSandwiches.Dequeue();
                }
                else
                {
                    queueStudents.Dequeue();
                    queueStudents.Enqueue(firstStudent);
                }
            }

            Console.WriteLine(String.Join(",", queueStudents));
            Console.WriteLine(String.Join(",", sstackSandwiches));

            return queueStudents.Count();
        }
    }
}
