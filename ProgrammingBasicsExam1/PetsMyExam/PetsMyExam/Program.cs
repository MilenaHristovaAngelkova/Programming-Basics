using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsMyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double foodPerDayDogKg = double.Parse(Console.ReadLine());
            double foodPerDayCatKg = double.Parse(Console.ReadLine());
            double foodPerDayTortoiseGramms = double.Parse(Console.ReadLine());

            double foodNeededByDogKG = days * foodPerDayDogKg;
            double foodNeededByCatKG = days * foodPerDayCatKg;
            double foodNeededByTortoiseKG = days * (foodPerDayTortoiseGramms / 1000);

            double foodNeededTotal = foodNeededByDogKG + foodNeededByCatKG + foodNeededByTortoiseKG;
            double difference = Math.Abs(foodLeftKg - foodNeededTotal);

            if (foodLeftKg >= foodNeededTotal)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(difference));
            }
        }
    }
}
