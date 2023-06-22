using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGamePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BaseballGamePoints(new string[] { "1", "C", "-62", "-45", "-68" }));
            Console.WriteLine(BaseballGamePoints(new string[] { "5", "2", "C", "D", "+" }));
            Console.WriteLine(BaseballGamePoints(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }));
            Console.WriteLine(BaseballGamePoints(new string[] { "1", "C" }));
        }

        public static int BaseballGamePoints(string[] operations)
        {
            var pointsList = new List<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                int newPoints = 0;
                int firstNum = 0;

                if (pointsList.Count() >= 1)
                    firstNum = pointsList[pointsList.Count() - 1];

                if (operations[i] == "+")
                {
                    newPoints = firstNum + pointsList[pointsList.Count() - 2];
                    pointsList.Add(newPoints);
                }
                else if (operations[i] == "D")
                {
                    newPoints = firstNum * 2;
                    pointsList.Add(newPoints);
                }
                else if (operations[i] == "C")
                {
                    pointsList.Remove(firstNum);
                }
                else
                {
                    pointsList.Add(int.Parse(operations[i]));
                }
            }

            return pointsList.Sum();
        }
    }
}
