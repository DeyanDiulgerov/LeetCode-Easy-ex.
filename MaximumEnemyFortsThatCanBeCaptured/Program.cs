using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumEnemyFortsThatCanBeCaptured
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumEnemyFortsThatCanBeCaptured(new int[] { -1, -1, 0, 1, 0, 0, 1, -1, 1, 0 }));
            Console.WriteLine(MaximumEnemyFortsThatCanBeCaptured(new int[] { 1, 0, 0, -1, 0, 0, 0, 0, 1 }));
            Console.WriteLine(MaximumEnemyFortsThatCanBeCaptured(new int[] { 0, 0, 1, -1 }));
        }

        public static int MaximumEnemyFortsThatCanBeCaptured(int[] forts)
        {
            int n = forts.Length;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (forts[i] == 1)
                {
                    int leftCount = 0, rightCount = 0;
                    bool existsEmptyFort = false;

                    for (int r = i + 1; r < n; r++)
                    {
                        if (forts[r] == 0)
                            rightCount++;
                        else if (forts[r] == -1)
                        {
                            existsEmptyFort = true;
                            break;
                        }
                        else if (forts[r] == 1)
                            break;
                    }

                    if (existsEmptyFort == false)
                        rightCount = 0;

                    existsEmptyFort = false;
                    for (int l = i - 1; l >= 0; l--)
                    {
                        if (forts[l] == 0)
                            leftCount++;
                        else if (forts[l] == -1)
                        {
                            existsEmptyFort = true;
                            break;
                        }
                        else if (forts[l] == 1)
                            break;
                    }
                    if (existsEmptyFort == false)
                        leftCount = 0;

                    var newMax = Math.Max(leftCount, rightCount);
                    max = Math.Max(max, newMax);
                }
            }
            return max;
        }
    }
}
