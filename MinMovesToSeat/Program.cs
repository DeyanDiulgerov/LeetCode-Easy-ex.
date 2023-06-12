using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMovesToSeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinMovesToSeat(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 }));
            Console.WriteLine(MinMovesToSeat(new int[] { 4, 1, 5, 9 }, new int[] { 1, 3, 2, 6 }));
            Console.WriteLine(MinMovesToSeat(new int[] { 2, 2, 6, 6 }, new int[] { 1, 3, 2, 6 }));
        }

        public static int MinMovesToSeat(int[] seats, int[] students)
        {
            int n = seats.Count();
            int counter = 0;

            var listedSeats = new List<int>(seats);
            var listedStudents = new List<int>(students);

            listedSeats.Sort();
            listedStudents.Sort();

            for (int i = 0; i < n; i++)
            {
                var currSeat = listedSeats[i];
                var currStudent = listedStudents[i];

                while (currSeat != currStudent)
                {
                    if (currSeat > currStudent)
                        currStudent++;
                    else
                        currStudent--;

                    counter++;
                }
            }

            return counter;
        }
    }
}
