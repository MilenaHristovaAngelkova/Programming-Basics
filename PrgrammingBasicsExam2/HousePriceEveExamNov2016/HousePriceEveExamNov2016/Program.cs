using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePriceEveExamNov2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double pricePerSqrMeter = double.Parse(Console.ReadLine());

            double bathroomArea = smallestRoomArea / 2;
            double secondRoomArea = smallestRoomArea + (smallestRoomArea * 0.10);
            double thirdRoomArea = secondRoomArea + (secondRoomArea * 0.10);

            double areaRooms = smallestRoomArea + kitchenArea + secondRoomArea + thirdRoomArea + bathroomArea;
            double areaTotal = areaRooms + (areaRooms * 0.05);
            double price = areaTotal * pricePerSqrMeter;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
