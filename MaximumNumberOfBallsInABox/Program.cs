using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfBallsInABox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumNumberOfBallsInABox(11, 104));
            Console.WriteLine(MaximumNumberOfBallsInABox(1, 10));
            Console.WriteLine(MaximumNumberOfBallsInABox(5, 15));
            Console.WriteLine(MaximumNumberOfBallsInABox(19, 28));
        }

        public static int MaximumNumberOfBallsInABox(int lowLimit, int highLimit)
        {
            int n = highLimit - lowLimit + 1;
            var boxAndBallsDict = new Dictionary<int, int>();

            for (int i = lowLimit; i <= highLimit; i++)
            {
                var strBall = i.ToString();
                var sumBall = 0;

                for (int j = 0; j < strBall.Length; j++)
                    sumBall += strBall[j] - 48;

                if (!boxAndBallsDict.ContainsKey(sumBall))
                    boxAndBallsDict.Add(sumBall, 1);
                else
                    boxAndBallsDict[sumBall]++;
            }

            foreach (var kvp in boxAndBallsDict.OrderByDescending(x => x.Value))
            {
                return kvp.Value;
            }

            return 0;
        }
    }
}
