using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxMyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = (2 * n) + (n / 3);
            int columns = (2 * n) + 3;
            int upperStarCount = 1;
            int middleStarCount = (n / 2) + 1;
            int lowerDashCount = 1;

            for (int currentRow = 0; currentRow < rows + 1; currentRow++)
            {
                if (currentRow < n)
                {
                    Console.WriteLine("{0}\\{1}/{0}", new string('*', upperStarCount),
                        new string('-', columns - 2 - (2 * upperStarCount)));
                    upperStarCount++;
                }
                else if (currentRow == n)
                {
                    Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2),
                        new string('*', columns - 4 - (2 * (n / 2))));
                }
                else if (currentRow > n && currentRow < rows - n)
                {
                    Console.WriteLine("|{0}\\{1}/{0}|", new string('*', middleStarCount),
                        new string('*', columns - 4 - (2 * middleStarCount)));
                    middleStarCount++;
                }
                else if (currentRow > rows - n)
                {
                    Console.WriteLine("{0}\\{1}/{0}", new string('-', lowerDashCount),
                        new string('*', columns - 2 - (2 * lowerDashCount)));
                    lowerDashCount++;
                }
            }
        }
    }
}
