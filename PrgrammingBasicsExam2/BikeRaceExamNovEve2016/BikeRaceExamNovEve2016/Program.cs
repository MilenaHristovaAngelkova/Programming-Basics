using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRaceExamNovEve2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();

            double juniorsPrice = 0.00;
            double seniorsPrice = 0.00;
            
            if (raceType == "trail")
            {
                juniorsPrice = 5.50;
                seniorsPrice = 7.00;
            }
            else if (raceType == "cross-country")
            {
                juniorsPrice = 8.00;
                seniorsPrice = 9.50;                
            }
            else if (raceType == "downhill")
            {
                juniorsPrice = 12.25;
                seniorsPrice = 13.75;
            }
            else if (raceType == "road")
            {
                juniorsPrice = 20.00;
                seniorsPrice = 21.50;
            }
            else
            {
                Console.WriteLine();
            }

            double priceTotal = (juniors * juniorsPrice) + (seniors * seniorsPrice);
            if (raceType == "cross-country" && (juniors + seniors) >= 50)
            {
                priceTotal = priceTotal * 0.75;
            }

            double expenses = priceTotal * 0.05;
            double donatedFunds = priceTotal - expenses;

            Console.WriteLine("{0:f2}", donatedFunds);
        }
    }
}
