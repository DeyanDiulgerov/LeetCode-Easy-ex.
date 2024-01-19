using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParkingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            parkingSystem.AddCar(1);
            parkingSystem.AddCar(2);
            parkingSystem.AddCar(3);
            parkingSystem.AddCar(1);
        }
        public class ParkingSystem
        {
            Dictionary<int, int> availableSpacesMap;
            public ParkingSystem(int big, int medium, int small)
            {
                availableSpacesMap = new Dictionary<int, int>();
                availableSpacesMap.Add(1, big);
                availableSpacesMap.Add(2, medium);
                availableSpacesMap.Add(3, small);
                Console.WriteLine($"We have {availableSpacesMap[1]} big available parking spaces");
                Console.WriteLine($"We have {availableSpacesMap[2]} medium available parking spaces");
                Console.WriteLine($"We have {availableSpacesMap[3]} small available parking spaces");
            }
            public bool AddCar(int carType)
            {
                if (availableSpacesMap[carType] > 0)
                {
                    availableSpacesMap[carType]--;
                    Console.WriteLine($"There was an empty parking space");
                    Console.WriteLine($"{carType} space left: {availableSpacesMap[carType]}");
                    return true;
                }
                Console.WriteLine($"There werent any empty parking spaces");
                return false;
            }
        }
    }
}
