using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = (n * 2) - 1;
            int asterixCount = 1;
            for (int currRow = 0; currRow < rows; currRow++)
            {
                int emptySpacesCount = n - asterixCount;
                Console.Write(new string(' ', emptySpacesCount));

                for (int currAst = 0; currAst < asterixCount; currAst++)
                {
                    Console.Write("* ");
                }

                if (currRow < n - 1)
                {
                    asterixCount++;
                }
                else
                {
                    asterixCount--;
                }

                Console.WriteLine();
            }

        }
    }
}