using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathCrossing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PathCrossing("NES"));
            Console.WriteLine(PathCrossing("NESWW"));
        }

        public static bool PathCrossing(string path)
        {
            var pathsCrossed = new List<string>();
            int x = 0, y = 0;
            pathsCrossed.Add($"{0},{0}");

            for (int i = 0; i < path.Length; i++)
            {
                switch (path[i])
                {
                    case 'N':
                        x++;
                        break;
                    case 'E':
                        y++;
                        break;
                    case 'S':
                        x--;
                        break;
                    case 'W':
                        y--;
                        break;
                }
                var currPath = $"{x},{y}";
                if (pathsCrossed.Contains(currPath))
                    return true;
                else
                    pathsCrossed.Add(currPath);
            }
            return false;
        }
    }
}
