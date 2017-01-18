using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                int rows = n - 1;
                int asterixCount = 2;
                int middleDashesCount = 2;

                for (int currentRow = 1; currentRow <= rows; currentRow++)
                {
                    if (currentRow == 1 || currentRow == rows)
                    {
                        Console.Write("{0}{1}{0}", new string('-', (n - asterixCount) / 2),
                            new string('*', asterixCount));
                        Console.WriteLine();
                    }
                    else if (currentRow == (rows / 2) + 1)
                    {
                        Console.Write("*{0}*", new string('-', n - 2));
                        Console.WriteLine();
                    }
                    else if (currentRow < (rows / 2) + 1)
                    {
                        int sideDashesCount = (n - asterixCount - middleDashesCount) / 2;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', sideDashesCount),
                            new string('-', middleDashesCount));
                        middleDashesCount += 2;

                    }
                    else if (currentRow > (rows / 2) + 1)
                    {
                        middleDashesCount -= 2;
                        int sideDashesCount = (n - asterixCount - middleDashesCount) / 2;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', sideDashesCount),
                            new string('-', middleDashesCount));
                    }
                }
            }
            else if (n % 2 == 1)
            {
                int rowsOdd = n;
                int asterixCountOdd = 1;
                int middleDashesCountOdd = 1;

                for (int currentRowOdd = 1; currentRowOdd <= rowsOdd; currentRowOdd++)
                {
                    if (currentRowOdd == 1 || currentRowOdd == rowsOdd)
                    {
                        Console.Write("{0}{1}{0}", new string('-', (n - asterixCountOdd) / 2),
                            new string('*', asterixCountOdd));
                        Console.WriteLine();
                    }
                    else if (currentRowOdd == (rowsOdd / 2) + 1)
                    {
                        Console.Write("*{0}*", new string('-', n - 2));
                        Console.WriteLine();
                    }
                    else if (currentRowOdd < (rowsOdd / 2) + 1)
                    {
                        int sideDashesCountOdd = (n - asterixCountOdd - middleDashesCountOdd) / 2;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', sideDashesCountOdd),
                            new string('-', middleDashesCountOdd));
                        middleDashesCountOdd += 2;
                    }
                    else if (currentRowOdd > (rowsOdd / 2) + 1)
                    {
                        middleDashesCountOdd -= 2;
                        int sideDashesCountOdd = (n - asterixCountOdd - middleDashesCountOdd) / 2;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', sideDashesCountOdd),
                            new string('-', middleDashesCountOdd));
                    }
                }
            }            
        }
    }
}
    
