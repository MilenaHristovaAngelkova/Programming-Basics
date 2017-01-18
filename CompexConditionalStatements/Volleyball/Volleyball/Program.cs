using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int localTownWeekend = h;
            double sofiaWeekend = 48 - h;
            double volleyballSofiaWeekend = sofiaWeekend * (3.0 / 4);
            int volleyballTown = h;
            double volleyballP = p * (2.0 / 3);

            double volleyballTotal = volleyballSofiaWeekend + volleyballTown + volleyballP;

            if (yearType == "leap")
                {
                volleyballTotal = volleyballTotal + (volleyballTotal * 0.15);
                volleyballTotal = Math.Truncate(volleyballTotal);
                Console.WriteLine(volleyballTotal);
                }
            else if (yearType == "normal")
            {
                volleyballTotal = Math.Truncate(volleyballTotal);
                Console.WriteLine(volleyballTotal);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
