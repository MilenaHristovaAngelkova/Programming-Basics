using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());

            for (int currRow = 1; currRow <= row; currRow++)
            {
                Console.Write('*');
                for (int currCol = 1; currCol < row; currCol++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
