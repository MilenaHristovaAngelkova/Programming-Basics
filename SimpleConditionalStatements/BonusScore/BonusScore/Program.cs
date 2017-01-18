using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingPoints = double.Parse(Console.ReadLine());
            double bonusPoints = 0.0;

            if (startingPoints <= 100)
            {
                bonusPoints += 5;
            }
            else if (startingPoints > 100 && startingPoints <= 1000)
            {
                bonusPoints += startingPoints * 0.2;
            }
            else if (startingPoints > 1000)
            {
                bonusPoints += 0.1 * startingPoints;
            }

            if (startingPoints % 2 == 0)
            {
                bonusPoints += 1;
            }

            if (startingPoints % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + startingPoints);
        }
    }
}
