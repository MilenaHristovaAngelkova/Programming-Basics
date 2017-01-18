using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationMyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transportType = Console.ReadLine();

            double priceTravelling = 0.00;            

            if (transportType == "train")
            {
                double adultsTrain = 24.99;
                double studentsTrain = 14.99;
                priceTravelling = (adults * adultsTrain) + (students * studentsTrain);
                if ((adults + students) >= 50)
                {
                    priceTravelling = priceTravelling - (priceTravelling * 0.50);
                }
            }
            else if (transportType == "bus")
            {
                double adultsBus = 32.50;
                double studentsBus = 28.50;
                priceTravelling = (adults * adultsBus) + (students * studentsBus);
            }
            else if (transportType == "boat")
            {
                double adultsShip = 42.99;
                double studentsShip = 39.99;
                priceTravelling = (adults * adultsShip) + (students * studentsShip);
            }
            else if (transportType == "airplane")
            {
                double adultsPlane = 70.00;
                double studentsPlane = 50.00;
                priceTravelling = (adults * adultsPlane) + (students * studentsPlane);
            }

            double priceHotel = nights * 82.99;
            double priceGroup = (2 * priceTravelling) + priceHotel;
            double commission = priceGroup * 0.10;
            double priceTotal = priceGroup + commission;

            Console.WriteLine("{0:f2}", priceTotal);
        }
    }
}
