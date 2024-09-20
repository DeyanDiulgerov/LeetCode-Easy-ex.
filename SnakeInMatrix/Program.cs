using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commands1 = new List<string>() { "RIGHT", "DOWN" };
            var commands2 = new List<string>() { "DOWN", "RIGHT", "UP" };
            Console.WriteLine(SnakeInMatrix(2, commands1));
            Console.WriteLine(SnakeInMatrix(3, commands2));
        }

        public static int SnakeInMatrix(int n, IList<string> commands)
        {
            // n == grid.length
            var map = new Dictionary<string, int>()
            {
                {"RIGHT", 0},
                {"DOWN", 0}
            };
            foreach (var command in commands)
            {
                switch (command)
                {
                    case "RIGHT":
                        map["RIGHT"]++;
                        break;
                    case "LEFT":
                        map["RIGHT"]--;
                        break;
                    case "DOWN":
                        map["DOWN"]++;
                        break;
                    case "UP":
                        map["DOWN"]--;
                        break;
                }
            }
            int result = map["RIGHT"];

            if (map["DOWN"] > 0)
            {
                result += map["DOWN"] * n;
            }
            return result;
        }
    }
}
