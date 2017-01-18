using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCampMyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double sum = 0.00;

            double studentsCar = 0.00;
            double studentsVan = 0.00;
            double stundentsSmallBus = 0.00;
            double studentsLargeBus = 0.00;
            double studentsTrain = 0.00;

            for (int i = 1; i <= students; i++)
            {
                int studentsPerGroup = int.Parse(Console.ReadLine());
                sum += studentsPerGroup;

                if (studentsPerGroup < 6)
                {
                    studentsCar += studentsPerGroup;
                }
                else if (studentsPerGroup > 5 && studentsPerGroup < 13)
                {
                    studentsVan += studentsPerGroup;
                }
                else if (studentsPerGroup > 12 && studentsPerGroup < 26)
                {
                    stundentsSmallBus += studentsPerGroup;
                }
                else if (studentsPerGroup > 25 && studentsPerGroup < 41)
                {
                    studentsLargeBus += studentsPerGroup;
                }
                else if (studentsPerGroup > 40)
                {
                    studentsTrain += studentsPerGroup;
                }                
            }

            double studentsCarTotal = studentsCar / sum * 100;
            double studentsVanTotal = studentsVan / sum * 100;
            double stundentsSmallBusTotal = stundentsSmallBus / sum * 100;
            double studentsLargeBusTotal = studentsLargeBus / sum * 100;
            double studentsTrainTotal = studentsTrain / sum * 100;

            Console.WriteLine("{0:F2}%", studentsCarTotal);
            Console.WriteLine("{0:F2}%", studentsVanTotal);
            Console.WriteLine("{0:F2}%", stundentsSmallBusTotal);
            Console.WriteLine("{0:F2}%", studentsLargeBusTotal);
            Console.WriteLine("{0:F2}%", studentsTrainTotal);
        }
    }
}
