using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOf10By10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;
            int symbolsPerRow = 10;

            for (int currRow = 0; currRow < rows; currRow++)
            {
                Console.WriteLine(new string('*', symbolsPerRow));
            }
        }
    }
}
