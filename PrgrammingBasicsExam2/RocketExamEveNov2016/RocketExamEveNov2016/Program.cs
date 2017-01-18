using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketExamEveNov2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int columns = 3 * n;
            int rows = (3 * n) + (n / 2) + 1;
            int topSideDotsCount = columns - 2;
            int bottomSideDotsCount = n / 2;
            int bottomAsterixCount = columns - n - 2;

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                if (currentRow == 0)
                {
                    Console.WriteLine("{0}/\\{0}", new string('.', topSideDotsCount / 2));
                    topSideDotsCount -= 2;
                }
                else if (currentRow > 0 && currentRow < n)
                {
                    Console.WriteLine("{0}/{1}\\{0}", new string('.', topSideDotsCount / 2), 
                        new string(' ', columns - topSideDotsCount - 2));
                    topSideDotsCount -= 2;
                }
                else if (currentRow == n)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', columns - n));
                }
                else if (currentRow > n && currentRow < rows - (n / 2))
                {
                    Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), 
                        new string('\\', columns - n - 2));
                }
                else if (currentRow >= rows - (n / 2))
                {
                    Console.WriteLine("{0}/{1}\\{0}", new string('.', bottomSideDotsCount), 
                        new string('*', bottomAsterixCount));
                    bottomSideDotsCount --;
                    bottomAsterixCount += 2;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
