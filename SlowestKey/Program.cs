using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowestKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SlowestKey(new int[] { 19, 22, 28, 29, 66, 81, 93, 97 }, "fnfaaxha"));
            Console.WriteLine(SlowestKey(new int[] { 9, 29, 49, 50 }, "cbcd"));
            Console.WriteLine(SlowestKey(new int[] { 12, 23, 36, 46, 62 }, "spuda"));
        }
        public static char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            var keyAndTimeMap = new Dictionary<char, int>();

            for (int i = 0; i < releaseTimes.Length; i++)
            {
                var time = 0;
                var key = keysPressed[i];
                if (i == 0)
                    time = releaseTimes[i];
                else
                    time = releaseTimes[i] - releaseTimes[i - 1];

                if (!keyAndTimeMap.ContainsKey(key))
                    keyAndTimeMap.Add(key, time);
                else
                {
                    if (keyAndTimeMap[key] < time)
                        keyAndTimeMap[key] = time;
                }
            }
            keyAndTimeMap = keyAndTimeMap
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            return keyAndTimeMap.First().Key;
        }
    }
}
